using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UniversityRegistration
{
    public partial class StudentForm : Form
    {
        int currentStudentId;
        int currentMajorId;
        string currentStudentName;

        static string connString = "Data Source= RDPWindows\\SQLEXPRESS; Initial Catalog=UniversityDB; Integrated Security=True; TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);

        public StudentForm(int studentId, int majorId, string studentName)
        {
            InitializeComponent();
            this.currentStudentId = studentId;
            this.currentMajorId = majorId;
            this.currentStudentName = studentName;

            // Link the Double Click Events
            dgv_available.CellDoubleClick += CourseDetails_DoubleClick;
            dgv_registered.CellDoubleClick += CourseDetails_DoubleClick;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Welcome, {currentStudentName} (ID: {currentStudentId})";
            SetupGrids();
            LoadAvailableCourses();
            LoadRegisteredHistory();
            RefreshStats();
        }

        private void SetupGrids()
        {
            ConfigureGrid(dgv_available);
            ConfigureGrid(dgv_registered);
        }

        private void ConfigureGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;

            // Using columns to hold the data structured
            dgv.Columns.Add("id", "ID");           // Col 0: Hidden ID
            dgv.Columns.Add("code", "Code");       // Col 1
            dgv.Columns.Add("title", "Title");     // Col 2
            dgv.Columns.Add("credits", "Credits"); // Col 3

            dgv.Columns[0].Visible = false;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadAvailableCourses()
        {
            dgv_available.Rows.Clear();
            string query = "SELECT course_id, course_code, course_title, credits FROM Courses WHERE major_id = @mid";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mid", currentMajorId);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dgv_available.Rows.Add(r["course_id"], r["course_code"], r["course_title"], r["credits"]);
                }
            }
            catch (Exception ex) { MessageBox.Show("Load Error: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void LoadRegisteredHistory()
        {
            dgv_registered.Rows.Clear();
            string query = @"SELECT c.course_id, c.course_code, c.course_title, c.credits 
                             FROM Enrollments e 
                             JOIN Courses c ON e.course_id = c.course_id 
                             WHERE e.student_id = @sid";
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", currentStudentId);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dgv_registered.Rows.Add(r["course_id"], r["course_code"], r["course_title"], r["credits"]);
                }
            }
            catch (Exception ex) { MessageBox.Show("History Load Error: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void CourseDetails_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView dgv = (DataGridView)sender;

            // Extract the hidden ID and Title from the row
            string courseId = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            string courseTitle = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();

            string query = "SELECT course_description FROM Courses WHERE course_id = @cid";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cid", courseId);
                object desc = cmd.ExecuteScalar();
                string message = (desc == DBNull.Value || desc == null) ? "No description." : desc.ToString();
                MessageBox.Show(message, $"Course Details: {courseTitle}");
            }
            finally { conn.Close(); }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_available.SelectedRows)
            {
                bool exists = false;
                foreach (DataGridViewRow regRow in dgv_registered.Rows)
                {
                    if (regRow.Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                        exists = true;
                }

                if (!exists)
                {
                    dgv_registered.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_registered.SelectedRows)
            {
                // Note: This only removes it from the UI grid. 
                // If it's already in the DB, it won't delete it from the DB unless you add a DELETE query here.
                dgv_registered.Rows.Remove(row);
            }
        }

        private void btn_finalize_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                foreach (DataGridViewRow row in dgv_registered.Rows)
                {
                    int cid = Convert.ToInt32(row.Cells[0].Value);

                    string check = "SELECT COUNT(*) FROM Enrollments WHERE student_id=@sid AND course_id=@cid";
                    SqlCommand checkCmd = new SqlCommand(check, conn);
                    checkCmd.Parameters.AddWithValue("@sid", currentStudentId);
                    checkCmd.Parameters.AddWithValue("@cid", cid);

                    if ((int)checkCmd.ExecuteScalar() == 0)
                    {
                        string ins = "INSERT INTO Enrollments (student_id, course_id, reg_date) VALUES (@sid, @cid, GETDATE())";
                        SqlCommand cmd = new SqlCommand(ins, conn);
                        cmd.Parameters.AddWithValue("@sid", currentStudentId);
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registration successfully finalized!");
            }
            finally
            {
                conn.Close();
                LoadRegisteredHistory();
                RefreshStats();
            }
        }

        private void RefreshStats()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = @"SELECT COUNT(e.course_id), SUM(c.credits) 
                                 FROM Enrollments e 
                                 JOIN Courses c ON e.course_id = c.course_id 
                                 WHERE e.student_id = @sid";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sid", currentStudentId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int count = reader[0] != DBNull.Value ? Convert.ToInt32(reader[0]) : 0;
                    int sum = reader[1] != DBNull.Value ? Convert.ToInt32(reader[1]) : 0;
                    lbl_stats.Text = $"Registered: {count} courses | Total Credits: {sum}";
                }
            }
            catch { }
            finally { conn.Close(); }
        }

        // --- MENU ACTIONS ---
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e) { new Login().Show(); this.Close(); }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e) { Application.Exit(); }
        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e) { LoadAvailableCourses(); LoadRegisteredHistory(); RefreshStats(); }
    }
}