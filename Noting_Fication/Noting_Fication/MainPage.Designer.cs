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
            panel1 = new Panel();
            btnList = new Button();
            panel3 = new Panel();
            btnGoals = new Button();
            panel2 = new Panel();
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
            // MenuContainer
            // 
            MenuContainer.Controls.Add(btnMenu);
            MenuContainer.Location = new Point(3, 4);
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
            // 
            // SearchContainer
            // 
            SearchContainer.Location = new Point(3, 111);
            SearchContainer.Margin = new Padding(3, 4, 3, 4);
            SearchContainer.Name = "SearchContainer";
            SearchContainer.Size = new Size(321, 99);
            SearchContainer.TabIndex = 2;
            // 
            // NewContainer
            // 
            NewContainer.Controls.Add(btnNew);
            NewContainer.Location = new Point(3, 218);
            NewContainer.Margin = new Padding(3, 4, 3, 4);
            NewContainer.Name = "NewContainer";
            NewContainer.Size = new Size(321, 69);
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
            TasksContainer.Location = new Point(3, 295);
            TasksContainer.Margin = new Padding(3, 4, 3, 4);
            TasksContainer.Name = "TasksContainer";
            TasksContainer.Size = new Size(321, 69);
            TasksContainer.TabIndex = 3;
            // 
            // btnTasks
            // 
            btnTasks.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTasks.Location = new Point(0, 5);
            btnTasks.Margin = new Padding(3, 4, 3, 4);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(318, 60);
            btnTasks.TabIndex = 0;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click_1;
            // 
            // TagsContainer
            // 
            TagsContainer.Controls.Add(btnTags);
            TagsContainer.Location = new Point(3, 372);
            TagsContainer.Margin = new Padding(3, 4, 3, 4);
            TagsContainer.Name = "TagsContainer";
            TagsContainer.Size = new Size(321, 69);
            TagsContainer.TabIndex = 4;
            // 
            // btnTags
            // 
            btnTags.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnTags.Location = new Point(0, 5);
            btnTags.Margin = new Padding(3, 4, 3, 4);
            btnTags.Name = "btnTags";
            btnTags.Size = new Size(318, 60);
            btnTags.TabIndex = 0;
            btnTags.Text = "Bin";
            btnTags.UseVisualStyleBackColor = true;
            btnTags.Click += btnTags_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnList);
            panel1.Location = new Point(3, 449);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 69);
            panel1.TabIndex = 5;
            // 
            // btnList
            // 
            btnList.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnList.Location = new Point(0, 5);
            btnList.Margin = new Padding(3, 4, 3, 4);
            btnList.Name = "btnList";
            btnList.Size = new Size(318, 60);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGoals);
            panel3.Location = new Point(3, 526);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 69);
            panel3.TabIndex = 6;
            // 
            // btnGoals
            // 
            btnGoals.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoals.Location = new Point(0, 5);
            btnGoals.Margin = new Padding(3, 4, 3, 4);
            btnGoals.Name = "btnGoals";
            btnGoals.Size = new Size(318, 60);
            btnGoals.TabIndex = 0;
            btnGoals.Text = "Test Editform";
            btnGoals.UseVisualStyleBackColor = true;
            btnGoals.Click += btnGoals_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 40, 45);
            panel2.Location = new Point(331, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(1099, 660);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 840);
            Controls.Add(panel2);
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
        private Button btnTasks;
        private Panel TagsContainer;
        private Button btnTags;
        private Panel panel1;
        private Button btnList;
        private Panel panel2;
        private Panel panel3;
        private Button btnGoals;
    }
}