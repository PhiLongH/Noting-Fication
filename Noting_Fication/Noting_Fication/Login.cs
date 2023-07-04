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

namespace Noting_Fication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        String ConnectionString = "server =(local); database= NotingFication; uid=sa;pwd=12345; TrustServerCertificate=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var pwd = txtPassword.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", pwd);

                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();
                    connection.Close();

                    if (userCount > 0)
                    {

                        // Successful login for an Administrator
                        MessageBox.Show("Success", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 mainPage = new Form1();
                        mainPage.Show();
                    }
                    else
                    {
                        // Failed login
                        MessageBox.Show("Invalid username or password", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating the user: " + ex.Message);
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rs = new Register();
            rs.Show();
            lblRegister.LinkVisited = true;
        }
    }
}
