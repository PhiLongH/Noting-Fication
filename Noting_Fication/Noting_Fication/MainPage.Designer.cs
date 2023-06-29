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
            sidebar.MaximumSize = new Size(284, 681);
            sidebar.MinimumSize = new Size(57, 681);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(284, 681);
            sidebar.TabIndex = 0;
            // 
            // MenuContainer
            // 
            MenuContainer.Controls.Add(btnMenu);
            MenuContainer.Location = new Point(3, 3);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(281, 74);
            MenuContainer.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(0, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(275, 68);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button1_Click;
            // 
            // SearchContainer
            // 
            SearchContainer.Location = new Point(3, 83);
            SearchContainer.Name = "SearchContainer";
            SearchContainer.Size = new Size(281, 74);
            SearchContainer.TabIndex = 2;
            // 
            // NewContainer
            // 
            NewContainer.Controls.Add(btnNew);
            NewContainer.Location = new Point(3, 163);
            NewContainer.Name = "NewContainer";
            NewContainer.Size = new Size(281, 52);
            NewContainer.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(0, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(278, 45);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // TasksContainer
            // 
            TasksContainer.Controls.Add(btnTasks);
            TasksContainer.Location = new Point(3, 221);
            TasksContainer.Name = "TasksContainer";
            TasksContainer.Size = new Size(281, 52);
            TasksContainer.TabIndex = 3;
            // 
            // btnTasks
            // 
            btnTasks.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTasks.Location = new Point(0, 4);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(278, 45);
            btnTasks.TabIndex = 0;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // TagsContainer
            // 
            TagsContainer.Controls.Add(btnTags);
            TagsContainer.Location = new Point(3, 279);
            TagsContainer.Name = "TagsContainer";
            TagsContainer.Size = new Size(281, 52);
            TagsContainer.TabIndex = 4;
            // 
            // btnTags
            // 
            btnTags.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTags.Location = new Point(0, 4);
            btnTags.Name = "btnTags";
            btnTags.Size = new Size(278, 45);
            btnTags.TabIndex = 0;
            btnTags.Text = "Tags";
            btnTags.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 8;
            timer1.Tick += sideBartimer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Location = new Point(345, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(881, 612);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(sidebar);
            Name = "Form1";
            Text = "Form1";
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