namespace Noting_Fication
{
    partial class CreateNote
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
            lblTitle = new Label();
            textBox1 = new TextBox();
            lblTags = new Label();
            TagslistContainer = new FlowLayoutPanel();
            lblTemplate = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(111, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 23);
            textBox1.TabIndex = 1;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblTags.Location = new Point(111, 218);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(88, 47);
            lblTags.TabIndex = 2;
            lblTags.Text = "Tags";
            // 
            // TagslistContainer
            // 
            TagslistContainer.Location = new Point(111, 268);
            TagslistContainer.Name = "TagslistContainer";
            TagslistContainer.Size = new Size(332, 122);
            TagslistContainer.TabIndex = 3;
            TagslistContainer.Paint += flowLayoutPanel1_Paint;
            // 
            // lblTemplate
            // 
            lblTemplate.AutoSize = true;
            lblTemplate.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblTemplate.Location = new Point(111, 408);
            lblTemplate.Name = "lblTemplate";
            lblTemplate.Size = new Size(175, 47);
            lblTemplate.TabIndex = 4;
            lblTemplate.Text = "Templates";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(111, 474);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(332, 122);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(843, 170);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(332, 426);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(744, 100);
            label1.Name = "label1";
            label1.Size = new Size(303, 47);
            label1.TabIndex = 7;
            label1.Text = "Templates Preview";
            // 
            // CreateNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblTemplate);
            Controls.Add(TagslistContainer);
            Controls.Add(lblTags);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Name = "CreateNote";
            Text = "CreateNote";
            Load += CreateNote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox textBox1;
        private Label lblTags;
        private FlowLayoutPanel TagslistContainer;
        private Label lblTemplate;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
    }
}