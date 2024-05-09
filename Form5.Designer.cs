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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(407, 279);
            backButton.Name = "backButton";
            backButton.Size = new Size(116, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(64, 241);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(121, 23);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // subjectsComboBox
            // 
            subjectsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectsComboBox.FormattingEnabled = true;
            subjectsComboBox.Location = new Point(283, 58);
            subjectsComboBox.Name = "subjectsComboBox";
            subjectsComboBox.Size = new Size(121, 23);
            subjectsComboBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 50);
            label1.Name = "label1";
            label1.Size = new Size(258, 31);
            label1.TabIndex = 6;
            label1.Text = "Subjects to select from";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 117);
            label2.Name = "label2";
            label2.Size = new Size(164, 13);
            label2.TabIndex = 7;
            label2.Text = "*you can pick several subjects*";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(556, 318);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(subjectsComboBox);
            Controls.Add(submitButton);
            Controls.Add(backButton);
            Name = "Form5";
            Text = "Subjects";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button submitButton;
        private ComboBox subjectsComboBox;
        private Label label1;
        private Label label2;
    }
}