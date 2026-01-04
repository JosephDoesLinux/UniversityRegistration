using Microsoft.Data.SqlClient;
using System.Data;
namespace UniversityRegistration

{
    public partial class Form1 : Form
    {
        static string connString = "Data Source= RDPWindows\\SQLEXPRESS;" +
            " Initial Catalog=MarketDB; Integrated Security=True;" +
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
    }
}
