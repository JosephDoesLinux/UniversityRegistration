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
            // Example Login Button Code
            string query = "SELECT user_id, user_role FROM dbo.Users WHERE user_id=@id AND password=@pass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@pass", txt_password.Text);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) // If a record is found
            {
                int userId = (int)reader["user_id"];
                string role = reader["user_role"].ToString();

                if (role == "Admin")
                    new AdminPanelForm().Show();
                else
                    new StudentForm(userId).Show(); // Pass ID to the next form

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
