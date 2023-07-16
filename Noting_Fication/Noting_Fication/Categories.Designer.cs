namespace Noting_Fication
{
    partial class Categories
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            Note_Categories = new ListView();
            notecategories_scroll = new VScrollBar();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Categories_flowlayout = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Categories_scroll = new VScrollBar();
            listCate = new TreeView();
            btn_AddCat = new Button();
            btn_DeleteCat = new Button();
            button1 = new Button();
            btnExit = new Button();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Categories_flowlayout.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.Controls.Add(Note_Categories);
            flowLayoutPanel2.Controls.Add(notecategories_scroll);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Location = new Point(364, 92);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(683, 424);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // Note_Categories
            // 
            Note_Categories.Location = new Point(3, 3);
            Note_Categories.Name = "Note_Categories";
            Note_Categories.Size = new Size(647, 419);
            Note_Categories.TabIndex = 2;
            Note_Categories.UseCompatibleStateImageBehavior = false;
            Note_Categories.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // notecategories_scroll
            // 
            notecategories_scroll.Cursor = Cursors.Hand;
            notecategories_scroll.Location = new Point(653, 0);
            notecategories_scroll.Name = "notecategories_scroll";
            notecategories_scroll.Size = new Size(26, 419);
            notecategories_scroll.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(84, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 84);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(371, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Location = new Point(-1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(79, 602);
            panel2.TabIndex = 0;
            // 
            // Categories_flowlayout
            // 
            Categories_flowlayout.BackColor = Color.Teal;
            Categories_flowlayout.Controls.Add(label1);
            Categories_flowlayout.Location = new Point(3, 3);
            Categories_flowlayout.Name = "Categories_flowlayout";
            Categories_flowlayout.Size = new Size(271, 33);
            Categories_flowlayout.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 0;
            label1.Text = "𝙲𝚊𝚝𝚎𝚐𝚘𝚛𝚒𝚎𝚜";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(Categories_flowlayout);
            flowLayoutPanel1.Controls.Add(Categories_scroll);
            flowLayoutPanel1.Controls.Add(listCate);
            flowLayoutPanel1.Location = new Point(84, 92);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(274, 424);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Categories_scroll
            // 
            Categories_scroll.Cursor = Cursors.Hand;
            Categories_scroll.Location = new Point(0, 39);
            Categories_scroll.Name = "Categories_scroll";
            Categories_scroll.Size = new Size(26, 383);
            Categories_scroll.TabIndex = 2;
            Categories_scroll.TabStop = true;
            // 
            // listCate
            // 
            listCate.Location = new Point(29, 42);
            listCate.Name = "listCate";
            listCate.Size = new Size(230, 377);
            listCate.TabIndex = 3;
            // 
            // btn_AddCat
            // 
            btn_AddCat.BackColor = Color.Transparent;
            btn_AddCat.Location = new Point(285, 519);
            btn_AddCat.Name = "btn_AddCat";
            btn_AddCat.Size = new Size(60, 29);
            btn_AddCat.TabIndex = 1;
            btn_AddCat.Text = "Add";
            btn_AddCat.TextAlign = ContentAlignment.TopCenter;
            btn_AddCat.UseVisualStyleBackColor = false;
            btn_AddCat.Click += btn_AddCat_Click;
            // 
            // btn_DeleteCat
            // 
            btn_DeleteCat.Location = new Point(212, 519);
            btn_DeleteCat.Name = "btn_DeleteCat";
            btn_DeleteCat.Size = new Size(67, 29);
            btn_DeleteCat.TabIndex = 2;
            btn_DeleteCat.Text = "Delete";
            btn_DeleteCat.UseVisualStyleBackColor = true;
            btn_DeleteCat.Click += btn_DeleteCat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 428);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(973, 522);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 603);
            Controls.Add(btnExit);
            Controls.Add(btn_DeleteCat);
            Controls.Add(btn_AddCat);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Categories_flowlayout.ResumeLayout(false);
            Categories_flowlayout.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel Categories_flowlayout;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView Note_Categories;
        private TreeView listCate;
        private VScrollBar Categories_scroll;
        private VScrollBar notecategories_scroll;
        private Button btn_AddCat;
        private Button btn_DeleteCat;
        private Button button1;
        private Button btnExit;
    }
}