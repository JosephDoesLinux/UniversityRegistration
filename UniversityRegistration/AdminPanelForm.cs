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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        static string connString = "Data Source= RDPWindows\\SQLEXPRESS;" +
            " Initial Catalog=UniversityDB; Integrated Security=True;" +
            " TrustServerCertificate=True";

        SqlConnection conn = new SqlConnection(connString);
        private void FillMajors()
        {
            // Display names like 'Computer Science', but keep the 'ID' in the background
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Majors", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_majors.DataSource = dt;
            cmb_majors.DisplayMember = "major_name"; // What the Admin sees
            cmb_majors.ValueMember = "major_id";     // The ID we save to the Course table
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Courses (course_code, course_title, credits, major_id) " +
                           "VALUES (@code, @title, @cred, @mid)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@code", txt_code.Text);
            cmd.Parameters.AddWithValue("@title", txt_title.Text);
            cmd.Parameters.AddWithValue("@cred", nud_credits.Value);
            cmd.Parameters.AddWithValue("@mid", cmb_majors.SelectedValue); // Logic from Week 12

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Course added to the specific major!");
            LoadCourses(); // Refresh your DataGridView
        }
        private void LoadCourses()
        {
            string query = "SELECT * FROM Courses";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_courses.DataSource = dt;
        }

        private void dgv_courses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure they didn't click the header
            {
                DataGridViewRow row = dgv_courses.Rows[e.RowIndex];
                txt_code.Text = row.Cells["course_code"].Value.ToString();
                txt_title.Text = row.Cells["course_title"].Value.ToString();
                nud_credits.Value = Convert.ToInt32(row.Cells["credits"].Value);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_courses.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_courses.CurrentRow.Cells["course_id"].Value);

                string query = "UPDATE Courses SET course_code=@code, course_title=@title, credits=@cred WHERE course_id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@code", txt_code.Text);
                cmd.Parameters.AddWithValue("@title", txt_title.Text);
                cmd.Parameters.AddWithValue("@cred", nud_credits.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Course Updated!");
                LoadCourses(); // Refresh the grid
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_courses.CurrentRow != null)
            {
                // Ask for confirmation (Good UX practice)
                DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgv_courses.CurrentRow.Cells["course_id"].Value);
                    string query = "DELETE FROM Courses WHERE course_id=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Course Deleted!");
                    LoadCourses();
                }
            }
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            FillMajors();   // Fills the ComboBox for Courses
            LoadCourses();  // Fills the DataGridView
            LoadMajors();   // Fills the ListView
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadMajors()
        {
            lv_majors.Items.Clear(); // Clear old data
            string query = "SELECT * FROM Majors";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // Create a new row (ListViewItem)
                ListViewItem item = new ListViewItem(reader["major_id"].ToString());
                item.SubItems.Add(reader["major_name"].ToString());

                lv_majors.Items.Add(item); // Add row to ListView
            }
            conn.Close();
        }

        private void lv_majors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_majors.SelectedItems.Count > 0)
            {
                // Get the text from the 2nd column (Index 1)
                txt_majorName.Text = lv_majors.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btn_addMajor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_majorName.Text)) return;

            string query = "INSERT INTO Majors (major_name) VALUES (@name)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txt_majorName.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            txt_majorName.Clear();
            LoadMajors();      // Refresh the ListView
            FillMajors();      // Refresh the ComboBox in the Courses tab
        }

        private void btn_updateMajor_Click(object sender, EventArgs e)
        {
            if (lv_majors.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(lv_majors.SelectedItems[0].Text);
                string query = "UPDATE Majors SET major_name = @name WHERE major_id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txt_majorName.Text);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadMajors();
                FillMajors();
            }
        }

        private void btn_deleteMajor_Click(object sender, EventArgs e)
        {
            if (lv_majors.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Delete this major?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lv_majors.SelectedItems[0].Text);
                    string query = "DELETE FROM Majors WHERE major_id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadMajors();
                    FillMajors();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_majorName.Clear();
        }
    }
}

