namespace Major_Project_Tosho
{
    partial class Form3
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
            majorsButton = new Button();
            subjectsButton = new Button();
            adminButton = new Button();
            SuspendLayout();
            // 
            // majorsButton
            // 
            majorsButton.Location = new Point(36, 26);
            majorsButton.Name = "majorsButton";
            majorsButton.Size = new Size(75, 23);
            majorsButton.TabIndex = 0;
            majorsButton.Text = "Majors";
            majorsButton.UseVisualStyleBackColor = true;
            majorsButton.Click += majorsButton_Click;
            // 
            // subjectsButton
            // 
            subjectsButton.Location = new Point(160, 26);
            subjectsButton.Name = "subjectsButton";
            subjectsButton.Size = new Size(75, 23);
            subjectsButton.TabIndex = 1;
            subjectsButton.Text = "Subjects";
            subjectsButton.UseVisualStyleBackColor = true;
            subjectsButton.Click += subjectsButton_Click;
            // 
            // adminButton
            // 
            adminButton.Enabled = false;
            adminButton.Location = new Point(287, 26);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(75, 23);
            adminButton.TabIndex = 2;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 71);
            Controls.Add(adminButton);
            Controls.Add(subjectsButton);
            Controls.Add(majorsButton);
            Name = "Form3";
            Text = "Main Page";
            ResumeLayout(false);
        }

        #endregion

        private Button majorsButton;
        private Button subjectsButton;
        private Button adminButton;
    }
}