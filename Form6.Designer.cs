namespace Major_Project_Tosho
{
    partial class Form6
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
            backButton = new Button();
            submitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(250, 243);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(41, 243);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 27);
            label1.Name = "label1";
            label1.Size = new Size(257, 35);
            label1.TabIndex = 5;
            label1.Text = "Hello, dear teacher!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 90);
            label2.Name = "label2";
            label2.Size = new Size(284, 15);
            label2.TabIndex = 6;
            label2.Text = "Student subjects: you have the rigths to edit subjects";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(362, 301);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submitButton);
            Controls.Add(backButton);
            Name = "Form6";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button submitButton;
        private Label label1;
        private Label label2;
    }
}