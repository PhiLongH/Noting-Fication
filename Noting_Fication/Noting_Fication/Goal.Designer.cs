namespace Noting_Fication
{
    partial class Goal
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            dTP_Deadline = new DateTimePicker();
            panel2 = new Panel();
            cmB_Status = new ComboBox();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label3 = new Label();
            txtNote = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleGreen;
            label1.Location = new Point(149, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 54);
            label1.TabIndex = 0;
            label1.Text = "ⓈⒺⓉ ⒼⓄⒶⓁ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 96);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 1;
            label2.Text = "𝙳𝚎𝚊𝚍𝚕𝚒𝚗𝚎";
            // 
            // dTP_Deadline
            // 
            dTP_Deadline.Location = new Point(205, 97);
            dTP_Deadline.Name = "dTP_Deadline";
            dTP_Deadline.Size = new Size(223, 27);
            dTP_Deadline.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtNote);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmB_Status);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dTP_Deadline);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 214);
            panel2.TabIndex = 3;
            // 
            // cmB_Status
            // 
            cmB_Status.FormattingEnabled = true;
            cmB_Status.Location = new Point(205, 158);
            cmB_Status.Name = "cmB_Status";
            cmB_Status.Size = new Size(191, 28);
            cmB_Status.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 158);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 5;
            label4.Text = "𝚂𝚝𝚊𝚝𝚞𝚜";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(380, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(71, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(489, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(102, 32);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 7;
            label3.Text = "𝙽𝚘𝚝𝚎";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(205, 32);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(287, 27);
            txtNote.TabIndex = 8;
            // 
            // Goal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 358);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Goal";
            Text = "Goal";
            Load += Goal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dTP_Deadline;
        private Panel panel2;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmB_Status;
        private Label label4;
        private TextBox txtNote;
        private Label label3;
    }
}