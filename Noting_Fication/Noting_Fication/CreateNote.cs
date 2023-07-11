using Noting_Fication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noting_Fication
{
    public partial class CreateNote : Form
    {
        static int iduser;
        public CreateNote(int id)
        {
            iduser = id;
            InitializeComponent();
            SetColors();
        }
        private void SetColors()
        {
            this.BackColor = AppColors.Lime; // Set the background color of the form
            button1.BackColor = AppColors.Green; // Set the background color of a button
            button1.ForeColor = Color.White; // Set the text color of a button
            lblCreateNote.ForeColor = AppColors.DarkBlue;
            panel1.BackColor = Color.White;

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Note n = new Note();
            n.Name = textBox1.Text;
            n.Content = textBox2.Text;
            n.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
            n.UserId = iduser;
            n.CreateDate = DateTime.Now;
            n.Status = true;
            n.Deadline = dateTimePicker1.Value;
            if (n.Name == "" || n.Content == "")
            {
                MessageBox.Show("Ban can nhap day du thong tin");
            }
            else
            {
                try
                {
                    using (var context = new NotingFication_2Context())
                    {
                        context.Notes.Add(n);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Add thanh cong Note!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void CreateNote_Load_1(object sender, EventArgs e)
        {
            using (var context = new NotingFication_2Context())
            {
                List<Category> list = context.Categories.ToList();
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryId";
                comboBox1.DataSource = list;
            }
            int cornerRadius = 10;
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddArc(panel1.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddArc(panel1.Width - cornerRadius * 2, panel1.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddArc(0, panel1.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.CloseFigure();

            // Set the rounded rectangle region to the Panel control
            panel1.Region = new Region(roundedRect);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
