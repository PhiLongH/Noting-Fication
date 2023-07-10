namespace Noting_Fication
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtxbContent = new RichTextBox();
            btBold = new Button();
            btNormal = new Button();
            btItalic = new Button();
            numericUpDown1 = new NumericUpDown();
            btUnderline = new Button();
            cbFont = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // rtxbContent
            // 
            rtxbContent.Location = new Point(12, 57);
            rtxbContent.Name = "rtxbContent";
            rtxbContent.Size = new Size(776, 391);
            rtxbContent.TabIndex = 0;
            rtxbContent.Text = "";
            rtxbContent.TextChanged += richTextBox1_TextChanged;
            // 
            // btBold
            // 
            btBold.Location = new Point(289, 13);
            btBold.Name = "btBold";
            btBold.Size = new Size(33, 29);
            btBold.TabIndex = 1;
            btBold.Text = "B";
            btBold.UseVisualStyleBackColor = true;
            btBold.Click += btBold_Click;
            // 
            // btNormal
            // 
            btNormal.Location = new Point(406, 13);
            btNormal.Name = "btNormal";
            btNormal.Size = new Size(33, 29);
            btNormal.TabIndex = 3;
            btNormal.Text = "N";
            btNormal.UseVisualStyleBackColor = true;
            btNormal.Click += btNormal_Click;
            // 
            // btItalic
            // 
            btItalic.Location = new Point(328, 13);
            btItalic.Name = "btItalic";
            btItalic.Size = new Size(33, 29);
            btItalic.TabIndex = 4;
            btItalic.Text = "I";
            btItalic.UseVisualStyleBackColor = true;
            btItalic.Click += btItalic_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(196, 13);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 27);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btUnderline
            // 
            btUnderline.Location = new Point(367, 13);
            btUnderline.Name = "btUnderline";
            btUnderline.Size = new Size(33, 29);
            btUnderline.TabIndex = 6;
            btUnderline.Text = "U";
            btUnderline.UseVisualStyleBackColor = true;
            btUnderline.Click += btUnderline_Click;
            // 
            // cbFont
            // 
            cbFont.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFont.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFont.FormattingEnabled = true;
            cbFont.Items.AddRange(new object[] { "Arial", "Avenir", "Baskerville", "Bodoni", "Book Antiqua", "Bookman Old Style", "Brush Script MT", "Calibri", "Calibri", "Cambria", "Candara", "Century Gothic", "Century Schoolbook", "Clarendon", "Comic Sans MS", "Consolas", "Copperplate Gothic", "Courier", "Courier New", "Didot", "Edwardian Script ITC", "Engravers MT", "Eurostile", "Felix Titling", "Forte", "Franklin Gothic", "Franklin Gothic Medium", "Frutiger", "Futura", "Garamond", "Georgia", "Gill Sans", "Gill Sans", "Gotham", "Gotham", "Goudy Stout", "Helvetica", "Impact", "Impact", "ITC Avant Garde Gothic", "Lucida Console", "Lucida Handwriting", "Lucida Handwriting", "Magneto", "Marlett", "Microsoft Sans Serif", "Monotype Corsiva", "Myriad", "Myriad Pro", "Neutraface", "Optima", "Palatino Linotype", "Proxima Nova", "Rockwell", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Tahoma", "Times New Roman", "Times New Roman", "Trade Gothic", "Trebuchet MS", "Univers", "Verdana", "Verdana", "Webdings", "Wingdings", "Wingdings 2", "Wingdings 3" });
            cbFont.Location = new Point(39, 12);
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(151, 28);
            cbFont.Sorted = true;
            cbFont.TabIndex = 7;
            cbFont.Text = "Times New Romen";
            cbFont.SelectedIndexChanged += cbFont_SelectedIndexChanged;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbFont);
            Controls.Add(btUnderline);
            Controls.Add(numericUpDown1);
            Controls.Add(btItalic);
            Controls.Add(btNormal);
            Controls.Add(btBold);
            Controls.Add(rtxbContent);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxbContent;
        private Button btBold;
        private Button btNormal;
        private Button btItalic;
        private NumericUpDown numericUpDown1;
        private Button btUnderline;
        private ComboBox cbFont;
    }
}