namespace Development
{
    partial class CustomerUI
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginLabel = new System.Windows.Forms.Label();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feedbackTextBox = new System.Windows.Forms.RichTextBox();
            this.ratingTable = new System.Windows.Forms.DataGridView();
            this.snColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criteriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excellentColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.goodColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.averageColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dissatisfiedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginAsAdminButton = new System.Windows.Forms.Button();
            this.serviceNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ratingTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(305, 164);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(258, 28);
            this.customerNameTextBox.TabIndex = 11;
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameTextBox.Location = new System.Drawing.Point(565, 530);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(258, 28);
            this.serviceNameTextBox.TabIndex = 10;
            // 
            // adminLoginLabel
            // 
            this.adminLoginLabel.AutoSize = true;
            this.adminLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminLoginLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginLabel.ForeColor = System.Drawing.Color.Black;
            this.adminLoginLabel.Location = new System.Drawing.Point(430, 30);
            this.adminLoginLabel.Name = "adminLoginLabel";
            this.adminLoginLabel.Size = new System.Drawing.Size(408, 34);
            this.adminLoginLabel.TabIndex = 9;
            this.adminLoginLabel.Text = "Rating and Feedback System";
            this.adminLoginLabel.Click += new System.EventHandler(this.adminLoginLabel_Click);
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.serviceNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameLabel.ForeColor = System.Drawing.Color.Black;
            this.serviceNameLabel.Location = new System.Drawing.Point(423, 104);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(153, 23);
            this.serviceNameLabel.TabIndex = 8;
            this.serviceNameLabel.Text = "Service Name:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.Color.Black;
            this.customerNameLabel.Location = new System.Drawing.Point(117, 164);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(176, 23);
            this.customerNameLabel.TabIndex = 7;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTextBox.Location = new System.Drawing.Point(903, 160);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(258, 28);
            this.contactNumberTextBox.TabIndex = 14;
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactNoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoLabel.ForeColor = System.Drawing.Color.Black;
            this.contactNoLabel.Location = new System.Drawing.Point(699, 165);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(182, 23);
            this.contactNoLabel.TabIndex = 13;
            this.contactNoLabel.Text = "Contact Number:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextBox.Location = new System.Drawing.Point(305, 214);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(258, 28);
            this.emailAddressTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(118, 215);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(151, 23);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Any Feedback?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackTextBox.Location = new System.Drawing.Point(305, 265);
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(258, 85);
            this.feedbackTextBox.TabIndex = 18;
            this.feedbackTextBox.Text = "";
            // 
            // ratingTable
            // 
            this.ratingTable.AllowUserToAddRows = false;
            this.ratingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snColumn,
            this.criteriaColumn,
            this.descriptionColumn,
            this.excellentColumn,
            this.goodColumn,
            this.averageColumn,
            this.dissatisfiedColumn});
            this.ratingTable.Location = new System.Drawing.Point(12, 378);
            this.ratingTable.Name = "ratingTable";
            this.ratingTable.RowHeadersWidth = 51;
            this.ratingTable.RowTemplate.Height = 24;
            this.ratingTable.Size = new System.Drawing.Size(1259, 286);
            this.ratingTable.TabIndex = 19;
            this.ratingTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snColumn
            // 
            this.snColumn.HeaderText = "SN";
            this.snColumn.MinimumWidth = 6;
            this.snColumn.Name = "snColumn";
            this.snColumn.Width = 125;
            // 
            // criteriaColumn
            // 
            this.criteriaColumn.HeaderText = "Criteria";
            this.criteriaColumn.MinimumWidth = 6;
            this.criteriaColumn.Name = "criteriaColumn";
            this.criteriaColumn.Width = 125;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.MinimumWidth = 6;
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.Width = 125;
            // 
            // excellentColumn
            // 
            this.excellentColumn.HeaderText = "Excellent";
            this.excellentColumn.MinimumWidth = 6;
            this.excellentColumn.Name = "excellentColumn";
            this.excellentColumn.Width = 125;
            // 
            // goodColumn
            // 
            this.goodColumn.HeaderText = "Good";
            this.goodColumn.MinimumWidth = 6;
            this.goodColumn.Name = "goodColumn";
            this.goodColumn.Width = 125;
            // 
            // averageColumn
            // 
            this.averageColumn.HeaderText = "Average";
            this.averageColumn.MinimumWidth = 6;
            this.averageColumn.Name = "averageColumn";
            this.averageColumn.Width = 125;
            // 
            // dissatisfiedColumn
            // 
            this.dissatisfiedColumn.HeaderText = "Dissatisfied";
            this.dissatisfiedColumn.MinimumWidth = 6;
            this.dissatisfiedColumn.Name = "dissatisfiedColumn";
            this.dissatisfiedColumn.Width = 125;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(903, 210);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(258, 28);
            this.addressTextBox.TabIndex = 21;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.Black;
            this.addressLabel.Location = new System.Drawing.Point(699, 210);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(93, 23);
            this.addressLabel.TabIndex = 20;
            this.addressLabel.Text = "Address:";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Teal;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(511, 690);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(291, 61);
            this.submitButton.TabIndex = 24;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(699, 261);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(64, 23);
            this.dateLabel.TabIndex = 26;
            this.dateLabel.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker.Font = new System.Drawing.Font("Poppins Light", 10.2F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(903, 261);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(258, 33);
            this.dateTimePicker.TabIndex = 27;
            this.dateTimePicker.Value = new System.DateTime(2021, 1, 18, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Development.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(1231, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loginAsAdminButton
            // 
            this.loginAsAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginAsAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAsAdminButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsAdminButton.ForeColor = System.Drawing.Color.White;
            this.loginAsAdminButton.Location = new System.Drawing.Point(1013, 749);
            this.loginAsAdminButton.Name = "loginAsAdminButton";
            this.loginAsAdminButton.Size = new System.Drawing.Size(258, 42);
            this.loginAsAdminButton.TabIndex = 32;
            this.loginAsAdminButton.Text = "Login as Admin";
            this.loginAsAdminButton.UseVisualStyleBackColor = false;
            this.loginAsAdminButton.Click += new System.EventHandler(this.loginAsAdminButton_Click);
            // 
            // serviceNameComboBox
            // 
            this.serviceNameComboBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameComboBox.FormattingEnabled = true;
            this.serviceNameComboBox.Items.AddRange(new object[] {
            "Restaurant"});
            this.serviceNameComboBox.Location = new System.Drawing.Point(609, 103);
            this.serviceNameComboBox.Name = "serviceNameComboBox";
            this.serviceNameComboBox.Size = new System.Drawing.Size(258, 29);
            this.serviceNameComboBox.TabIndex = 33;
            this.serviceNameComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Development.Properties.Resources.empty_room_with_windows_1048_2924;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 803);
            this.Controls.Add(this.serviceNameComboBox);
            this.Controls.Add(this.loginAsAdminButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ratingTable);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.contactNoLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.adminLoginLabel);
            this.Controls.Add(this.serviceNameLabel);
            this.Controls.Add(this.customerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer User Interface";
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratingTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.Label adminLoginLabel;
        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox feedbackTextBox;
        private System.Windows.Forms.DataGridView ratingTable;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn snColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criteriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excellentColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn goodColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn averageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dissatisfiedColumn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginAsAdminButton;
        private System.Windows.Forms.ComboBox serviceNameComboBox;
    }
}