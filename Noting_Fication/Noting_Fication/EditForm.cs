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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBold_Click(object sender, EventArgs e)
        {
            Boldtext(rtxbContent);
        }

        private void btNormal_Click(object sender, EventArgs e)
        {
            Normaltext(rtxbContent);
        }
        
        private void btItalic_Click(object sender, EventArgs e)
        {
            Italictext(rtxbContent);
        }
        


        void Boldtext(RichTextBox rtxb)
        {
            Font newFont = new Font(rtxb.SelectionFont.FontFamily.Name, rtxb.SelectionFont.Size, FontStyle.Bold);
            rtxb.SelectionFont = newFont;
        }
        void Italictext(RichTextBox rtxb)
        {
            Font newFont = new Font(rtxb.SelectionFont.FontFamily.Name, rtxb.SelectionFont.Size, FontStyle.Italic);
            rtxb.SelectionFont = newFont;
        }
        void Normaltext(RichTextBox rtxb)
        {
            Font newFont = new Font(rtxb.SelectionFont.FontFamily.Name, rtxb.SelectionFont.Size, FontStyle.Regular);
            rtxb.SelectionFont = newFont;
        }
    }
}
