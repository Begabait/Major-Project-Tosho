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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // majorsButton
            // 
            majorsButton.Location = new Point(29, 242);
            majorsButton.Name = "majorsButton";
            majorsButton.Size = new Size(75, 23);
            majorsButton.TabIndex = 0;
            majorsButton.Text = "Majors";
            majorsButton.UseVisualStyleBackColor = true;
            majorsButton.Click += majorsButton_Click;
            // 
            // subjectsButton
            // 
            subjectsButton.Location = new Point(155, 242);
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
            adminButton.Location = new Point(284, 242);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(75, 23);
            adminButton.TabIndex = 2;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.BackgroundImage = Properties.Resources.LOGO;
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.InitialImage = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(62, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 183);
            panel1.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(402, 277);
            Controls.Add(panel1);
            Controls.Add(adminButton);
            Controls.Add(subjectsButton);
            Controls.Add(majorsButton);
            Name = "Form3";
            Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button majorsButton;
        private Button subjectsButton;
        private Button adminButton;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}