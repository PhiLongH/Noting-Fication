namespace Noting_Fication
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        public Form1()
        {
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

        private void btnTasks_Click(object sender, EventArgs e) //goals
        {

        }

        private void btnTags_Click(object sender, EventArgs e) //categories
        {

        }

        private void btnBin_Click(object sender, EventArgs e)
        {

        }

        private void btnListNote_Click(object sender, EventArgs e)
        {

        }
    }
}