namespace Noting_Fication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            MenuContainer = new Panel();
            btnMenu = new Button();
            SearchContainer = new Panel();
            NewContainer = new Panel();
            btnListNote = new Button();
            TasksContainer = new Panel();
            btnNew = new Button();
            TagsContainer = new Panel();
            btnGoals = new Button();
            panel1 = new Panel();
            btnTags = new Button();
            panel3 = new Panel();
            btnBin = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            sidebar.SuspendLayout();
            MenuContainer.SuspendLayout();
            NewContainer.SuspendLayout();
            TasksContainer.SuspendLayout();
            TagsContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(MenuContainer);
            sidebar.Controls.Add(SearchContainer);
            sidebar.Controls.Add(NewContainer);
            sidebar.Controls.Add(TasksContainer);
            sidebar.Controls.Add(TagsContainer);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.MaximumSize = new Size(325, 908);
            sidebar.MinimumSize = new Size(65, 908);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(325, 908);
            sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 69);
            panel2.TabIndex = 6;
            // 
            // MenuContainer
            // 
            MenuContainer.Controls.Add(btnMenu);
            MenuContainer.Location = new Point(3, 81);
            MenuContainer.Margin = new Padding(3, 4, 3, 4);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(321, 99);
            MenuContainer.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(0, 4);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(314, 91);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button1_Click;
            // 
            // SearchContainer
            // 
            SearchContainer.Location = new Point(3, 188);
            SearchContainer.Margin = new Padding(3, 4, 3, 4);
            SearchContainer.Name = "SearchContainer";
            SearchContainer.Size = new Size(321, 99);
            SearchContainer.TabIndex = 2;
            // 
            // NewContainer
            // 
            NewContainer.Controls.Add(btnListNote);
            NewContainer.Location = new Point(3, 295);
            NewContainer.Margin = new Padding(3, 4, 3, 4);
            NewContainer.Name = "NewContainer";
            NewContainer.Size = new Size(321, 69);
            NewContainer.TabIndex = 2;
            // 
            // btnListNote
            // 
            btnListNote.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnListNote.Location = new Point(0, 4);
            btnListNote.Margin = new Padding(3, 4, 3, 4);
            btnListNote.Name = "btnListNote";
            btnListNote.Size = new Size(318, 60);
            btnListNote.TabIndex = 0;
            btnListNote.Text = "ListNote";
            btnListNote.UseVisualStyleBackColor = true;
            btnListNote.Click += btnListNote_Click;
            // 
            // TasksContainer
            // 
            TasksContainer.Controls.Add(btnNew);
            TasksContainer.Location = new Point(3, 372);
            TasksContainer.Margin = new Padding(3, 4, 3, 4);
            TasksContainer.Name = "TasksContainer";
            TasksContainer.Size = new Size(321, 69);
            TasksContainer.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(0, 5);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(318, 60);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // TagsContainer
            // 
            TagsContainer.Controls.Add(btnGoals);
            TagsContainer.Location = new Point(3, 449);
            TagsContainer.Margin = new Padding(3, 4, 3, 4);
            TagsContainer.Name = "TagsContainer";
            TagsContainer.Size = new Size(321, 69);
            TagsContainer.TabIndex = 4;
            // 
            // btnGoals
            // 
            btnGoals.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoals.Location = new Point(0, 5);
            btnGoals.Margin = new Padding(3, 4, 3, 4);
            btnGoals.Name = "btnGoals";
            btnGoals.Size = new Size(318, 60);
            btnGoals.TabIndex = 0;
            btnGoals.Text = "Goals";
            btnGoals.UseVisualStyleBackColor = true;
            btnGoals.Click += btnTasks_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTags);
            panel1.Location = new Point(3, 526);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 69);
            panel1.TabIndex = 5;
            // 
            // btnTags
            // 
            btnTags.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTags.Location = new Point(0, 4);
            btnTags.Margin = new Padding(3, 4, 3, 4);
            btnTags.Name = "btnTags";
            btnTags.Size = new Size(318, 60);
            btnTags.TabIndex = 0;
            btnTags.Text = "Categories";
            btnTags.UseVisualStyleBackColor = true;
            btnTags.Click += btnTags_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBin);
            panel3.Location = new Point(3, 603);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 69);
            panel3.TabIndex = 7;
            // 
            // btnBin
            // 
            btnBin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnBin.Location = new Point(0, 4);
            btnBin.Margin = new Padding(3, 4, 3, 4);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(318, 60);
            btnBin.TabIndex = 0;
            btnBin.Text = "Bin";
            btnBin.UseVisualStyleBackColor = true;
            btnBin.Click += btnBin_Click;
            // 
            // timer1
            // 
            timer1.Interval = 8;
            timer1.Tick += sideBartimer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Location = new Point(394, 76);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1007, 816);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(sidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            sidebar.ResumeLayout(false);
            MenuContainer.ResumeLayout(false);
            NewContainer.ResumeLayout(false);
            TasksContainer.ResumeLayout(false);
            TagsContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel MenuContainer;
        private Panel SearchContainer;
        private Button btnMenu;
        private Panel NewContainer;
        private Button btnNew;
        private Panel TasksContainer;
        private Button btnGoals;
        private Panel TagsContainer;
        private Button btnTags;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnBin;
        private Panel panel2;
        private Button btnListNote;
        private Panel panel3;
    }
}