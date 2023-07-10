using Noting_Fication.Models;
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
    public partial class CreateNote : Form
    {
        static int iduser;
        public CreateNote(int id)
        {
            iduser = id;
            InitializeComponent();
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
            if(n.Name =="" || n.Content == "")
            {
                MessageBox.Show("Ban can nhap day du thong tin");
            }
            else
            {
                try
                {
                    using (var context = new NotingFicationContext())
                    {
                        context.Notes.Add(n);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Add thanh cong Note!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void CreateNote_Load_1(object sender, EventArgs e)
        {
            using (var context = new NotingFicationContext())
            {
                List<Category> list = context.Categories.ToList();
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryId";
                comboBox1.DataSource= list;
            }
        }
    }
}
