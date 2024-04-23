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
            label1.Location = new Point(37, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 139);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 58);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 4;
            label5.Text = "Email Address";
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(203, 67);
            fnameTextBox.Margin = new Padding(4, 5, 4, 5);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(141, 31);
            fnameTextBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 103);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 7;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(399, 160);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(146, 25);
            label8.TabIndex = 8;
            label8.Text = "Repeat Password";
            // 
            // snameTextBox
            // 
            snameTextBox.Location = new Point(203, 126);
            snameTextBox.Margin = new Padding(4, 5, 4, 5);
            snameTextBox.Name = "snameTextBox";
            snameTextBox.Size = new Size(141, 31);
            snameTextBox.TabIndex = 10;
            // 
            // rpasswordTextBox
            // 
            rpasswordTextBox.Location = new Point(571, 155);
            rpasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            rpasswordTextBox.Name = "rpasswordTextBox";
            rpasswordTextBox.PasswordChar = '*';
            rpasswordTextBox.Size = new Size(141, 31);
            rpasswordTextBox.TabIndex = 15;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(571, 98);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(141, 31);
            passwordTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(571, 53);
            emailTextBox.Margin = new Padding(4, 5, 4, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(141, 31);
            emailTextBox.TabIndex = 12;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(504, 220);
            registerButton.Margin = new Padding(4, 5, 4, 5);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(107, 38);
            registerButton.TabIndex = 16;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // AdminRadioButton
            // 
            AdminRadioButton.AutoSize = true;
            AdminRadioButton.Location = new Point(63, 226);
            AdminRadioButton.Margin = new Padding(4, 5, 4, 5);
            AdminRadioButton.Name = "AdminRadioButton";
            AdminRadioButton.Size = new Size(90, 29);
            AdminRadioButton.TabIndex = 17;
            AdminRadioButton.TabStop = true;
            AdminRadioButton.Text = "Admin";
            AdminRadioButton.UseVisualStyleBackColor = true;
            // 
            // StudentRadioButton
            // 
            StudentRadioButton.AutoSize = true;
            StudentRadioButton.Location = new Point(211, 226);
            StudentRadioButton.Margin = new Padding(4, 5, 4, 5);
            StudentRadioButton.Name = "StudentRadioButton";
            StudentRadioButton.Size = new Size(98, 29);
            StudentRadioButton.TabIndex = 18;
            StudentRadioButton.TabStop = true;
            StudentRadioButton.Text = "Student";
            StudentRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 293);
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
            Margin = new Padding(4, 5, 4, 5);
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