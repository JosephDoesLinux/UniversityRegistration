using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UniversityRegistration
{
    public partial class StudentForm : Form
    {
        // Class-level variables to store student info
        int currentStudentId;
        int currentMajorId;
        string currentStudentName;

        // NEW: Map to link Course Code (String) to the actual Course ID (Integer)
        // Key: "CSIT381", Value: 12 (the auto-increment ID)
        Dictionary<string, int> courseIdMap = new Dictionary<string, int>();

        static string connString = "Data Source= RDPWindows\\SQLEXPRESS;" +
            " Initial Catalog=UniversityDB; Integrated Security=True;" +
            " TrustServerCertificate=True";

        SqlConnection conn = new SqlConnection(connString);

        public StudentForm(int studentId, int majorId, string studentName)
        {
            InitializeComponent();
            this.currentStudentId = studentId;
            this.currentMajorId = majorId;
            this.currentStudentName = studentName;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Welcome, {currentStudentName} (ID: {currentStudentId})";
            LoadMajorCourses();
            RefreshStats();
            LoadRegisteredHistory();
        }

        // --- REGISTRATION LOGIC ---

        private void RefreshStats()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // JOIN on numeric course_id to get accurate credit sums
                string query = @"SELECT COUNT(e.course_id), SUM(c.credits) 
                                 FROM Enrollments e 
                                 JOIN Courses c ON e.course_id = c.course_id 
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

        private void LoadMajorCourses()
        {
            clb_availableCourses.Items.Clear();
            courseIdMap.Clear(); // Clear the map before reloading

            // Fetch the ID, Code, and Title
            string query = "SELECT course_id, course_code, course_title FROM Courses WHERE major_id = @mid";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@mid", currentMajorId);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string code = reader["course_code"].ToString();
                    int id = Convert.ToInt32(reader["course_id"]);
                    string displayString = $"{code} - {reader["course_title"]}";

                    // Add text to the UI list
                    clb_availableCourses.Items.Add(displayString);

                    // Add the relationship to our Dictionary
                    if (!courseIdMap.ContainsKey(code))
                    {
                        courseIdMap.Add(code, id);
                    }
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

        private void btn_finalize_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                foreach (var item in lb_registeredCourses.Items)
                {
                    // 1. Extract the Course Code (e.g., "CSIT381")
                    string courseCode = item.ToString().Split('-')[0].Trim();

                    // 2. Use the map to get the real Integer Course ID
                    if (courseIdMap.TryGetValue(courseCode, out int actualNumericId))
                    {
                        // 3. Insert the Integer ID into the numeric course_id column
                        string query = "INSERT INTO Enrollments (student_id, course_id, reg_date) VALUES (@uid, @cid, GETDATE())";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@uid", currentStudentId);
                        cmd.Parameters.AddWithValue("@cid", actualNumericId); // Correct numeric type
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registration successful!");
                lb_registeredCourses.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Finalize Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                RefreshStats();
                LoadRegisteredHistory();
            }
        }

        // --- MENU BAR ACTIONS ---

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        private void LoadRegisteredHistory()
        {
            lb_registeredCourses.Items.Clear();

            // Query to get the Code and Title of everything the student is ALREADY in
            string query = @"SELECT c.course_code, c.course_title 
                     FROM Enrollments e 
                     JOIN Courses c ON e.course_id = c.course_id 
                     WHERE e.student_id = @sid";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@sid", currentStudentId);

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lb_registeredCourses.Items.Add($"{reader["course_code"]} - {reader["course_title"]}");
                }
            }
            catch (Exception ex) { MessageBox.Show("History Load Error: " + ex.Message); }
            finally { conn.Close(); }
        }
    }
}