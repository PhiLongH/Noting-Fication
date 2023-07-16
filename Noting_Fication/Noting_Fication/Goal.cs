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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Noting_Fication
{
    public partial class Goal : Form
    {
        private String connectionString = "server =LAPTOP-GFP4TUFC\\HALAM_SE170579; database= NotingFication; uid=sa;pwd=12345; TrustServerCertificate=True";
        public DateTime SelectedDeadline { get; private set; }
        public Goal()
        {
            InitializeComponent();
        }

        private void Goal_Load(object sender, EventArgs e)
        {
            cmB_Status.Items.Add(new ComboBoxItem("In Progress", true));
            cmB_Status.Items.Add(new ComboBoxItem("Not Started", false));
            cmB_Status.Items.Add(new ComboBoxItem("Done", false));
            cmB_Status.SelectedIndex = 0;

            this.Load += Goal_Load;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime deadline = dTP_Deadline.Value;
            ComboBoxItem selecteStatus = (ComboBoxItem)cmB_Status.SelectedItem;
            bool status = selecteStatus.Status;
            String noteName = txtNote.Text.Trim();
            if (String.IsNullOrEmpty(noteName)||String.IsNullOrEmpty(status.ToString()))
            {
                MessageBox.Show("Please choose the valid name and status for the goal.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dTP_Deadline.Value > DateTime.Now)
            {
                SelectedDeadline = dTP_Deadline.Value;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a future date as the goal deadline.", "Invalid Deadline", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    String sql = "UPDATE Note SET Deadline = @deadline, Status = @status WHERE Name = @noteName;";
                    //String sql = "INSERT INTO Note (Deadline, Status) VALUES (@Deadline, @Status);";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Deadline", deadline);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                }

                //String selectedGoalSQL = "SELECT SCOPE_IDENTITY();";


                MessageBox.Show("Goal saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the goal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            dTP_Deadline.Value = DateTime.Today;
            cmB_Status.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public bool Status { get; set; }

        public ComboBoxItem(string text, bool status)
        {
            Text = text;
            Status = status;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
