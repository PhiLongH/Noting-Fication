using Microsoft.Data.SqlClient;
using System;
using System.Runtime.InteropServices;
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

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
            //Tells the function what attribute to set.
        }




        public Login()
        {
            InitializeComponent();
            // Set the BorderColor property of the text boxes



            // Add the text boxes to the form's controls collection
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        String ConnectionString = "server =LAPTOP-P1F3R3OG\\SQLEXPRESS; database= NotingFication; uid=sa;pwd=12345; TrustServerCertificate=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var pwd = txtPassword.Text;
            //Validate username input
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("You must enter your username to move on", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.BorderStyle = BorderStyle.FixedSingle;
                txtUsername.Focus();
                return;
            }
            else
            {
                txtUsername.BorderStyle = BorderStyle.None;
            }

            // Validate password input
            if (string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("You must enter your password to move on", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.BorderStyle = BorderStyle.FixedSingle;
                txtPassword.Focus();
                return;
            }
            else
            {
                txtUsername.BorderStyle = BorderStyle.None;
            }


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
