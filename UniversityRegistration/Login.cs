using Microsoft.Data.SqlClient;
using System.Data;
namespace UniversityRegistration

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        static string connString = "Data Source= RDPWindows\\SQLEXPRESS;" +
            " Initial Catalog=UniversityDB; Integrated Security=True;" +
            " TrustServerCertificate=True";

        SqlConnection conn = new SqlConnection(connString);



        private void link_ums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://syslb.liu.edu.lb/login/",
                UseShellExecute = true
            });
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // FIX: Include full_name and major_id in the SELECT statement
            string query = "SELECT user_id, user_role, full_name, major_id FROM dbo.Users WHERE user_id=@id AND password=@pass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@pass", txt_password.Text);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["user_role"].ToString();

                if (role == "Admin")
                {
                    new AdminPanelForm().Show();
                }
                else
                {
                    int studentId = Convert.ToInt32(reader["user_id"]);
                    // Ensure major_id isn't null in the DB to avoid conversion errors
                    int majorId = reader["major_id"] != DBNull.Value ? Convert.ToInt32(reader["major_id"]) : 0;
                    string studentName = reader["full_name"].ToString();

                    StudentForm studentTab = new StudentForm(studentId, majorId, studentName);
                    studentTab.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password");
            }
            conn.Close();
        }
    }
}
