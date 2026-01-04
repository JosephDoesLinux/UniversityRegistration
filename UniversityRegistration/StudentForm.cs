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

        private void RefreshStats()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Query to count current enrollments for this specific student
                string query = "SELECT COUNT(*) FROM Enrollments WHERE student_id = @sid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", currentStudentId);

                int count = (int)cmd.ExecuteScalar();
                lbl_stats.Text = $"You are currently registered in {count} courses.";
            }
            catch (Exception ex) { MessageBox.Show("Stats Error: " + ex.Message); }
            finally { conn.Close(); }
        }

        // Call RefreshStats() at the end of btn_finalize_Click to update the message instantly
        private void btn_finalize_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                foreach (var item in lb_registeredCourses.Items)
                {
                    string courseCode = item.ToString().Split(' ')[0];
                    // Note: Ensure your table column is 'course_code' to match your previous setup
                    string query = "INSERT INTO Enrollments (student_id, course_code, reg_date) VALUES (@uid, @code, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", currentStudentId);
                    cmd.Parameters.AddWithValue("@code", courseCode);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Registration successful!");
                conn.Close(); // Close to allow RefreshStats to open it
                RefreshStats();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); if (conn.State == ConnectionState.Open) conn.Close(); }
        }
        private void LoadMajorCourses()
        {
            clb_availableCourses.Items.Clear();
            string query = "SELECT course_code, course_title FROM Courses WHERE major_id = @mid";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@mid", currentMajorId);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Format as "CODE - Title"
                string item = $"{reader["course_code"]} - {reader["course_title"]}";
                clb_availableCourses.Items.Add(item);
            }
            conn.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Loop through all checked items in the CheckedListBox
            foreach (var item in clb_availableCourses.CheckedItems)
            {
                // Prevent duplicate registration in the UI list
                if (!lb_registeredCourses.Items.Contains(item))
                {
                    lb_registeredCourses.Items.Add(item);
                }
                else
                {
                    MessageBox.Show($"{item} is already in your registration list.");
                }
            }
        }
    }
}
