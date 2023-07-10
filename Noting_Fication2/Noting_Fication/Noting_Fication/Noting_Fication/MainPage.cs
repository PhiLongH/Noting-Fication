namespace Noting_Fication
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        static int iduser;
        public Form1(int id)
        {
            iduser = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void sideBartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnTasks_Click(object sender, EventArgs e)
        {

        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            Bins form = new Bins(iduser);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            CreateNote form = new CreateNote(iduser);
            form.Show();

        }
    }
}