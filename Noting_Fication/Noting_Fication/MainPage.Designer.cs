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
            MenuContainer = new Panel();
            btnMenu = new Button();
            SearchContainer = new Panel();
            NewContainer = new Panel();
            btnNew = new Button();
            TasksContainer = new Panel();
            btnTasks = new Button();
            TagsContainer = new Panel();
            btnTags = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            sidebar.SuspendLayout();
            MenuContainer.SuspendLayout();
            NewContainer.SuspendLayout();
            TasksContainer.SuspendLayout();
            TagsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(MenuContainer);
            sidebar.Controls.Add(SearchContainer);
            sidebar.Controls.Add(NewContainer);
            sidebar.Controls.Add(TasksContainer);
            sidebar.Controls.Add(TagsContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.MaximumSize = new Size(325, 908);
            sidebar.MinimumSize = new Size(65, 908);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(325, 908);
            sidebar.TabIndex = 0;
            // 
            // MenuContainer
            // 
            MenuContainer.Controls.Add(btnMenu);
            MenuContainer.Location = new Point(3, 4);
            MenuContainer.Margin = new Padding(3, 4, 3, 4);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(321, 98);
            MenuContainer.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(0, 4);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(314, 90);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // SearchContainer
            // 
            SearchContainer.Location = new Point(3, 110);
            SearchContainer.Margin = new Padding(3, 4, 3, 4);
            SearchContainer.Name = "SearchContainer";
            SearchContainer.Size = new Size(321, 98);
            SearchContainer.TabIndex = 2;
            // 
            // NewContainer
            // 
            NewContainer.Controls.Add(btnNew);
            NewContainer.Location = new Point(3, 216);
            NewContainer.Margin = new Padding(3, 4, 3, 4);
            NewContainer.Name = "NewContainer";
            NewContainer.Size = new Size(321, 70);
            NewContainer.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(0, 4);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(318, 60);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click_1;
            // 
            // TasksContainer
            // 
            TasksContainer.Controls.Add(btnTasks);
            TasksContainer.Location = new Point(3, 294);
            TasksContainer.Margin = new Padding(3, 4, 3, 4);
            TasksContainer.Name = "TasksContainer";
            TasksContainer.Size = new Size(321, 70);
            TasksContainer.TabIndex = 3;
            // 
            // btnTasks
            // 
            btnTasks.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTasks.Location = new Point(0, 6);
            btnTasks.Margin = new Padding(3, 4, 3, 4);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(318, 60);
            btnTasks.TabIndex = 0;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = true;
            // 
            // TagsContainer
            // 
            TagsContainer.Controls.Add(btnTags);
            TagsContainer.Location = new Point(3, 372);
            TagsContainer.Margin = new Padding(3, 4, 3, 4);
            TagsContainer.Name = "TagsContainer";
            TagsContainer.Size = new Size(321, 70);
            TagsContainer.TabIndex = 4;
            // 
            // btnTags
            // 
            btnTags.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTags.Location = new Point(0, 6);
            btnTags.Margin = new Padding(3, 4, 3, 4);
            btnTags.Name = "btnTags";
            btnTags.Size = new Size(318, 60);
            btnTags.TabIndex = 0;
            btnTags.Text = "Bin";
            btnTags.UseVisualStyleBackColor = true;
            btnTags.Click += btnTags_Click;
            // 
            // timer1
            // 
            timer1.Interval = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Location = new Point(394, 76);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1007, 816);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 840);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(sidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            MenuContainer.ResumeLayout(false);
            NewContainer.ResumeLayout(false);
            TasksContainer.ResumeLayout(false);
            TagsContainer.ResumeLayout(false);
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
        private Button btnTasks;
        private Panel TagsContainer;
        private Button btnTags;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}