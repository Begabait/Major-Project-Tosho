namespace Major_Project_Tosho
{
    partial class Form2
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
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            fnameTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            snameTextBox = new TextBox();
            rpasswordTextBox = new TextBox();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            registerButton = new Button();
            AdminRadioButton = new RadioButton();
            StudentRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 83);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 35);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 4;
            label5.Text = "Email Address";
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(142, 40);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(100, 23);
            fnameTextBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 62);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 7;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 96);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 8;
            label8.Text = "Repeat Password";
            // 
            // snameTextBox
            // 
            snameTextBox.Location = new Point(142, 76);
            snameTextBox.Name = "snameTextBox";
            snameTextBox.Size = new Size(100, 23);
            snameTextBox.TabIndex = 10;
            // 
            // rpasswordTextBox
            // 
            rpasswordTextBox.Location = new Point(400, 93);
            rpasswordTextBox.Name = "rpasswordTextBox";
            rpasswordTextBox.PasswordChar = '*';
            rpasswordTextBox.Size = new Size(100, 23);
            rpasswordTextBox.TabIndex = 15;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(400, 59);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(400, 32);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 12;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(353, 132);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 16;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // AdminRadioButton
            // 
            AdminRadioButton.AutoSize = true;
            AdminRadioButton.Location = new Point(44, 136);
            AdminRadioButton.Name = "AdminRadioButton";
            AdminRadioButton.Size = new Size(61, 19);
            AdminRadioButton.TabIndex = 17;
            AdminRadioButton.TabStop = true;
            AdminRadioButton.Text = "Admin";
            AdminRadioButton.UseVisualStyleBackColor = true;
            // 
            // StudentRadioButton
            // 
            StudentRadioButton.AutoSize = true;
            StudentRadioButton.Location = new Point(148, 136);
            StudentRadioButton.Name = "StudentRadioButton";
            StudentRadioButton.Size = new Size(66, 19);
            StudentRadioButton.TabIndex = 18;
            StudentRadioButton.TabStop = true;
            StudentRadioButton.Text = "Student";
            StudentRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(545, 176);
            Controls.Add(StudentRadioButton);
            Controls.Add(AdminRadioButton);
            Controls.Add(registerButton);
            Controls.Add(rpasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(snameTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(fnameTextBox);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox fnameTextBox;
        private Label label7;
        private Label label8;
        private TextBox snameTextBox;
        private TextBox rpasswordTextBox;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Button registerButton;
        private RadioButton AdminRadioButton;
        private RadioButton StudentRadioButton;
    }
}