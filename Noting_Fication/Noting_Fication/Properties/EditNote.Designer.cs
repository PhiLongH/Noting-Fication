namespace Noting_Fication.Properties
{
    partial class EditNote
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
            SuspendLayout();
            // 
            // rtxbContent
            // 
            rtxbContent.Location = new Point(17, 85);
            rtxbContent.Name = "rtxbContent";
            rtxbContent.Size = new Size(771, 353);
            rtxbContent.TabIndex = 0;
            rtxbContent.Text = "";
            rtxbContent.TextChanged += richTextBox1_TextChanged;
            // 
            // btBold
            // 
            btBold.Location = new Point(27, 28);
            btBold.Name = "btBold";
            btBold.Size = new Size(37, 29);
            btBold.TabIndex = 1;
            btBold.Text = "B";
            btBold.UseVisualStyleBackColor = true;
            btBold.Click += btBold_Click;
            // 
            // EditNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btBold);
            Controls.Add(rtxbContent);
            Name = "EditNote";
            Text = "EditNote";
            Load += EditNote_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxbContent;
        private Button btBold;
    }
}