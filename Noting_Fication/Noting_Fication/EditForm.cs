using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Noting_Fication
{
    public partial class EditForm : Form
    {
        private List<Color> colorOptions;
        Stack<string> undoList = new Stack<string>();
        public EditForm()
        {
            InitializeComponent();
            Loadfirst();

        }
        void Loadfirst()
        {
            Font newFont = new Font("Times New Romance", (int)numericUpDown1.Value, FontStyle.Regular);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            cbHighlight.DrawMode = DrawMode.OwnerDrawFixed;
            cbHighlight.DrawItem += comboBoxColors_DrawItem;

            colorOptions = new List<Color>
        {
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Red,

        };

            foreach (Color color in colorOptions)
            {
                cbHighlight.Items.Add(color);
            }
        }
        private void comboBoxColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0 && e.Index < cbHighlight.Items.Count)
            {
                Color color = (Color)cbHighlight.Items[e.Index];
                Brush brush = new SolidBrush(color);

                e.DrawBackground();
                e.Graphics.FillRectangle(brush, e.Bounds.Left + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4);
                e.Graphics.DrawString(color.Name, cbHighlight.Font, Brushes.Black, e.Bounds.Left + 30, e.Bounds.Top + 2);

                e.DrawFocusRectangle();
            }
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ChangedSize(rtxbContent, (int)numericUpDown1.Value);
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

        void Underlinetext(RichTextBox rtxb)
        {
            Font newFont = new Font(rtxb.SelectionFont.FontFamily.Name, rtxb.SelectionFont.Size, FontStyle.Underline);
            rtxb.SelectionFont = newFont;
        }
        void ChangedSize(RichTextBox rtxb, int size)
        {
            Font newFont = new Font(rtxb.SelectionFont.FontFamily.Name, size, rtxb.SelectionFont.Style);
            rtxb.SelectionFont = newFont;

        }

        private void btUnderline_Click(object sender, EventArgs e)
        {
            Underlinetext(rtxbContent);
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = this.cbFont.SelectedItem.ToString();
            this.rtxbContent.Font = new Font(choose, this.rtxbContent.Font.Size, this.rtxbContent.Font.Style);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (rtxbContent.CanRedo)
            {
                rtxbContent.Redo();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (rtxbContent.CanUndo)
            {
                rtxbContent.Undo();
            }
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e) //blue violet
        {
            rtxbContent.SelectionColor = Color.BlueViolet;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.White;
        }

        private void btnYellow_Green_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.YellowGreen;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.Green;
        }

        private void btnBlue_Green_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.FromArgb(13, 152, 186);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.Blue;
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.Red;
        }

        private void btnRed_Orange_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.OrangeRed;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.Orange;
        }

        private void btnYellow_Orange_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.FromArgb(255, 174, 66);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionColor = Color.Yellow;
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnHighlight_Click(object sender, EventArgs e)
        {
            if (rtxbContent.SelectionLength > 0 && cbHighlight.SelectedItem != null)
            {
                string selectedColor = cbHighlight.SelectedItem.ToString();

                Color highlightColor = Color.FromName(selectedColor);

                int startIndex = rtxbContent.SelectionStart;
                int length = rtxbContent.SelectionLength;

                rtxbContent.Select(startIndex, length);
                rtxbContent.SelectionBackColor = highlightColor;
                rtxbContent.SelectionLength = 0;
            }
        }

        private void btnBullet_Click(object sender, EventArgs e)
        {
            if (rtxbContent.SelectionBullet)
            {
                rtxbContent.SelectionBullet = false;
                btnBullet.BackColor = SystemColors.Control;
            }
            else
            {
                rtxbContent.SelectionBullet = true;
                btnBullet.BackColor = Color.LightBlue;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
