using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Noting_Fication
{
    public partial class Form1 : Form
    {
        static int iduser;
        public Form1(int id)
        {
            iduser = id;
            InitializeComponent();
        }

        public Form1()
        {
            InitializeComponent();
        }
        public void show(Form frm)
        {
            panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.AutoScroll = true;
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            Bins form = new Bins(iduser);
            show(form);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            CreateNote form = new CreateNote(iduser);
            show(form);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            show(categories);
        }

        private void btnTasks_Click_1(object sender, EventArgs e)
        {
            Goal form = new Goal();
            form.Show();
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {

        }
    }
}