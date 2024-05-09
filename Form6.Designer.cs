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
            dataGridView1 = new DataGridView();
            columnComboBox = new ComboBox();
            fieldComboBox = new ComboBox();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(259, 461);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(50, 461);
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
            label2.Location = new Point(76, 82);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 6;
            label2.Text = "Here, you can check student details";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(847, 231);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // columnComboBox
            // 
            columnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            columnComboBox.FormattingEnabled = true;
            columnComboBox.Items.AddRange(new object[] { "First_name", "Last_name", "Email", "Admin", "Majors", "Main_Subject" });
            columnComboBox.Location = new Point(206, 410);
            columnComboBox.Name = "columnComboBox";
            columnComboBox.Size = new Size(121, 23);
            columnComboBox.TabIndex = 8;
            columnComboBox.SelectedIndexChanged += columnComboBox_SelectedIndexChanged;
            // 
            // fieldComboBox
            // 
            fieldComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldComboBox.FormattingEnabled = true;
            fieldComboBox.Location = new Point(414, 410);
            fieldComboBox.Name = "fieldComboBox";
            fieldComboBox.Size = new Size(121, 23);
            fieldComboBox.TabIndex = 9;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(460, 461);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 10;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(971, 506);
            Controls.Add(refreshButton);
            Controls.Add(fieldComboBox);
            Controls.Add(columnComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submitButton);
            Controls.Add(backButton);
            Name = "Form6";
            Text = "Admin";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button submitButton;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox columnComboBox;
        private ComboBox fieldComboBox;
        private Button refreshButton;
    }
}