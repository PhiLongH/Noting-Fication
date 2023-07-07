namespace Noting_Fication.Properties
{
    public partial class EditNote : Form
    {
        public EditNote()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditNote_Load(object sender, EventArgs e)
        {

        }

        private void btBold_Click(object sender, EventArgs e)
        {
            BoldText(rtxbContent);
        }
        void BoldText(RichTextBox rtxb)
        {
            Font newFont = new Font(rtxb.SelectionFont.FontFamily.Name, rtxb.SelectionFont.Size, FontStyle.Bold);
        }
    }
}
