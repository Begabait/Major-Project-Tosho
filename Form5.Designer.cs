namespace Major_Project_Tosho
{
    partial class Form5
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
            subjectsComboBox = new ComboBox();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(187, 307);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(287, 307);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // subjectsComboBox
            // 
            subjectsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectsComboBox.FormattingEnabled = true;
            subjectsComboBox.Location = new Point(157, 125);
            subjectsComboBox.Name = "subjectsComboBox";
            subjectsComboBox.Size = new Size(121, 23);
            subjectsComboBox.TabIndex = 5;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 364);
            Controls.Add(subjectsComboBox);
            Controls.Add(submitButton);
            Controls.Add(backButton);
            Name = "Form5";
            Text = "Subjects";
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Button submitButton;
        private ComboBox subjectsComboBox;
    }
}