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
            // Updated query to include course_description
            string query = "INSERT INTO Courses (course_code, course_title, course_description, credits, major_id) " +
                           "VALUES (@code, @title, @desc, @cred, @mid)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@code", txt_code.Text);
            cmd.Parameters.AddWithValue("@title", txt_title.Text);
            cmd.Parameters.AddWithValue("@desc", txt_description.Text);
            cmd.Parameters.AddWithValue("@cred", nud_credits.Value);
            cmd.Parameters.AddWithValue("@mid", cmb_majors.SelectedValue);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course added successfully!");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { conn.Close(); RefreshDashboard(); }
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
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgv_courses.Rows[e.RowIndex];

                    txt_code.Text = row.Cells["course_code"].Value?.ToString();
                    txt_title.Text = row.Cells["course_title"].Value?.ToString();

                    // Safe Credit Loading
                    if (row.Cells["credits"].Value != null && row.Cells["credits"].Value != DBNull.Value)
                    {
                        int creditVal = Convert.ToInt32(row.Cells["credits"].Value);
                        // Ensure value is between the control's Min and Max (e.g., 1 and 10)
                        if (creditVal >= nud_credits.Minimum && creditVal <= nud_credits.Maximum)
                            nud_credits.Value = creditVal;
                        else
                            nud_credits.Value = nud_credits.Minimum;
                    }

                    // Fix for Description not filling
                    if (row.Cells["course_description"].Value != DBNull.Value && row.Cells["course_description"].Value != null)
                        txt_description.Text = row.Cells["course_description"].Value.ToString();
                    else
                        txt_description.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Selection Error: " + ex.Message);
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_courses.CurrentRow == null) return;

            int id = Convert.ToInt32(dgv_courses.CurrentRow.Cells["course_id"].Value);
            string query = "UPDATE Courses SET course_code=@code, course_title=@title, " +
                           "course_description=@desc, credits=@cred WHERE course_id=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@code", txt_code.Text);
            cmd.Parameters.AddWithValue("@title", txt_title.Text);
            cmd.Parameters.AddWithValue("@desc", txt_description.Text);
            cmd.Parameters.AddWithValue("@cred", nud_credits.Value);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Updated!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); RefreshDashboard(); }
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
            dgv_courses.AutoGenerateColumns = false;
            RefreshDashboard();
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
                    try
                    {
                        int id = Convert.ToInt32(lv_majors.SelectedItems[0].Text);
                        string query = "DELETE FROM Majors WHERE major_id = @id";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Major deleted successfully.");
                    }
                    catch (SqlException ex)
                    {
                        // SQL Server Error 547 = Foreign Key Constraint violation
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("ERROR: Cannot delete this Major. Please delete all Students and Courses assigned to this major first.");
                        }
                        else
                        {
                            MessageBox.Show("SQL Error: " + ex.Message);
                        }
                    }
                    finally
                    {
                        conn.Close();
                        LoadMajors();
                        FillMajors();
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_majorName.Clear();
        }
        private void LoadUsers()
        {
            // Use a LEFT JOIN so admins (who might not have a major) still show up
            string query = @"SELECT u.user_id, u.full_name, u.password, u.user_role, m.major_name 
                     FROM Users u 
                     LEFT JOIN Majors m ON u.major_id = m.major_id";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_users.DataSource = dt;
        }

        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_users.Rows[e.RowIndex];
                txt_userName.Text = row.Cells["full_name"].Value.ToString();
                txt_userPass.Text = row.Cells["password"].Value.ToString();

                // Handle Radio Buttons based on the role string
                string role = row.Cells["user_role"].Value.ToString();
                if (role == "Admin") rb_admin.Checked = true;
                else rb_student.Checked = true;

                // Handle the Major ComboBox
                if (row.Cells["major_name"].Value != DBNull.Value)
                {
                    cmb_userMajor.Text = row.Cells["major_name"].Value.ToString();
                }
                else
                {
                    cmb_userMajor.SelectedIndex = -1; // Clear selection if no major
                }
            }
        }

        private void btn_userUpdate_Click(object sender, EventArgs e)
        {
            if (dgv_users.CurrentRow == null) return;

            int id = Convert.ToInt32(dgv_users.CurrentRow.Cells["user_id"].Value);
            string role = rb_admin.Checked ? "Admin" : "Student";

            string query = @"UPDATE Users SET full_name=@name,
                     password=@pass, user_role=@role, major_id=@mid 
                     WHERE user_id=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", txt_userName.Text);
            cmd.Parameters.AddWithValue("@pass", txt_userPass.Text);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@mid", cmb_userMajor.SelectedValue);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("User Updated!");
            LoadUsers();
        }

        private void btn_userAdd_Click(object sender, EventArgs e)
        {
            string role = rb_admin.Checked ? "Admin" : "Student";

            string query = "INSERT INTO Users (full_name, password, user_role, major_id) " +
                           "VALUES (@name, @pass, @role, @mid)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txt_userName.Text);
            cmd.Parameters.AddWithValue("@pass", txt_userPass.Text);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@mid", cmb_userMajor.SelectedValue);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("New Account Created!");
            LoadUsers(); // Refresh the list
        }

        private void btn_userDelete_Click(object sender, EventArgs e)
        {
            if (dgv_users.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_users.CurrentRow.Cells["user_id"].Value);

                DialogResult result = MessageBox.Show("Delete this account permanently?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Users WHERE user_id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadUsers();
                    MessageBox.Show("User removed.");
                }
            }
        }
        private void FillUserMajors()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Majors", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_userMajor.DataSource = dt;
            cmb_userMajor.DisplayMember = "major_name";
            cmb_userMajor.ValueMember = "major_id";
        }
        private void RefreshDashboard()
        {
            FillMajors();
            FillUserMajors();
            LoadCourses();
            LoadMajors();
            LoadUsers();
        }

        private void btn_clearCourses_Click(object sender, EventArgs e)
        {
            {
                txt_code.Clear();
                txt_title.Clear();
                txt_description.Clear(); // The new multiline textbox
                nud_credits.Value = 1;   // Reset to default value

                if (cmb_majors.Items.Count > 0)
                    cmb_majors.SelectedIndex = 0; // Reset to first major

                dgv_courses.ClearSelection(); // Deselect rows in the grid
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/JosephDoesLinux/UniversityRegistration";

            try
            {
                // This opens the URL in the default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = githubUrl,
                    UseShellExecute = true // Required for .NET Core / .NET 5+
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link: " + ex.Message);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDashboard();
        }
    }
}


