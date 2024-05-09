namespace Major_Project_Tosho
{
    partial class Form4
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
            majorsComboBox = new ComboBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(262, 307);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // majorsComboBox
            // 
            majorsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            majorsComboBox.FormattingEnabled = true;
            majorsComboBox.Location = new Point(77, 76);
            majorsComboBox.Name = "majorsComboBox";
            majorsComboBox.Size = new Size(121, 23);
            majorsComboBox.TabIndex = 2;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(352, 303);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 3;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 338);
            Controls.Add(submitButton);
            Controls.Add(majorsComboBox);
            Controls.Add(backButton);
            Name = "Form4";
            Text = "Majors";
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private ComboBox majorsComboBox;
        private Button submitButton;
    }
}