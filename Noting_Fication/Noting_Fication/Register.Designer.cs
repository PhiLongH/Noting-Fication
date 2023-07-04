namespace Noting_Fication
{
    partial class Register
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
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRegisterName = new TextBox();
            txtRegisterPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtRegisterEmail = new TextBox();
            txtRegisterPhone = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(429, 75);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 79);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Username*: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 131);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Password*: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 191);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 3;
            label3.Text = "Confirm password*:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 248);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 300);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 5;
            label5.Text = "Phone: ";
            // 
            // txtRegisterName
            // 
            txtRegisterName.Location = new Point(242, 76);
            txtRegisterName.Name = "txtRegisterName";
            txtRegisterName.Size = new Size(125, 27);
            txtRegisterName.TabIndex = 6;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(242, 131);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(125, 27);
            txtRegisterPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(242, 191);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(125, 27);
            txtConfirmPassword.TabIndex = 8;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(242, 248);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(125, 27);
            txtRegisterEmail.TabIndex = 9;
            // 
            // txtRegisterPhone
            // 
            txtRegisterPhone.Location = new Point(242, 300);
            txtRegisterPhone.Name = "txtRegisterPhone";
            txtRegisterPhone.Size = new Size(125, 27);
            txtRegisterPhone.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRegisterPhone);
            Controls.Add(txtRegisterEmail);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegisterName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRegisterName;
        private TextBox txtRegisterPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtRegisterEmail;
        private TextBox txtRegisterPhone;
    }
}