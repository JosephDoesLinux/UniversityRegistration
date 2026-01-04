using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityRegistration
{
    public partial class StudentForm : Form
    {
        // Class-level variables to store student info
        int currentStudentId;
        int currentMajorId;
        string currentStudentName;

        static string connString = "Data Source= RDPWindows\\SQLEXPRESS;" +
            " Initial Catalog=UniversityDB; Integrated Security=True;" +
            " TrustServerCertificate=True";

        SqlConnection conn = new SqlConnection(connString);

        public StudentForm(int studentId, int majorId, string studentName)
        {
            InitializeComponent();
            // Assigning the passed values to our class variables
            this.currentStudentId = studentId;
            this.currentMajorId = majorId;
            this.currentStudentName = studentName;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // Display the welcome message
            lbl_welcome.Text = $"Welcome, {currentStudentName} (ID: {currentStudentId})";

            // Load data
            LoadMajorCourses();
            RefreshStats();
        }


        // --- REGISTRATION LOGIC ---

        private void RefreshStats()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // FIX: Join course_id from Enrollments to course_code from Courses
                string query = @"SELECT COUNT(e.course_id), SUM(c.credits) 
                                 FROM Enrollments e 
                                 JOIN Courses c ON e.course_id = c.course_code 
                                 WHERE e.student_id = @sid";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", currentStudentId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int courseCount = reader[0] != DBNull.Value ? Convert.ToInt32(reader[0]) : 0;
                    int creditSum = reader[1] != DBNull.Value ? Convert.ToInt32(reader[1]) : 0;

                    lbl_stats.Text = $"Registered: {courseCount} courses | Total Credits: {creditSum}";
                }
            }
            catch (Exception ex) { MessageBox.Show("Stats Error: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void btn_finalize_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                foreach (var item in lb_registeredCourses.Items)
                {
                    string courseCode = item.ToString().Split('-')[0].Trim();

                    // Using course_id to match your database schema
                    string query = "INSERT INTO Enrollments (student_id, course_id, reg_date) VALUES (@uid, @code, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", currentStudentId);
                    cmd.Parameters.AddWithValue("@code", courseCode);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Registration successful!");
                lb_registeredCourses.Items.Clear(); // Clear "cart" after success
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                RefreshStats();
            }
        }

        private void LoadMajorCourses()
        {
            clb_availableCourses.Items.Clear();
            string query = "SELECT course_code, course_title FROM Courses WHERE major_id = @mid";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@mid", currentMajorId);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string item = $"{reader["course_code"]} - {reader["course_title"]}";
                    clb_availableCourses.Items.Add(item);
                }
            }
            catch (Exception ex) { MessageBox.Show("Load Error: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            foreach (var item in clb_availableCourses.CheckedItems)
            {
                if (!lb_registeredCourses.Items.Contains(item))
                {
                    lb_registeredCourses.Items.Add(item);
                }
            }
        }



        // --- MENU BAR ACTIONS ---



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMajorCourses();
            RefreshStats();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/JosephDoesLinux/UniversityRegistration";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = githubUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link: " + ex.Message);
            }
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            new Login().Show();
            this.Close();
        }
    }
    }
