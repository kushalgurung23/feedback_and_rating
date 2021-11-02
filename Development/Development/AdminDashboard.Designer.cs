namespace Development
{
    partial class AdminDashboard
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
            this.signOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerDashboardButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.addCriteriaBtn = new System.Windows.Forms.Button();
            this.viewReportBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.bulkDataEntryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signOutButton
            // 
            this.signOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.ForeColor = System.Drawing.Color.White;
            this.signOutButton.Location = new System.Drawing.Point(1232, 24);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(131, 63);
            this.signOutButton.TabIndex = 4;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rating and Feedback System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Development.Properties.Resources.rating;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(37, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 77);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Development.Properties.Resources.Dashboard;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Location = new System.Drawing.Point(-1, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 675);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customerDashboardButton
            // 
            this.customerDashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerDashboardButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDashboardButton.ForeColor = System.Drawing.Color.White;
            this.customerDashboardButton.Location = new System.Drawing.Point(306, 24);
            this.customerDashboardButton.Name = "customerDashboardButton";
            this.customerDashboardButton.Size = new System.Drawing.Size(246, 63);
            this.customerDashboardButton.TabIndex = 8;
            this.customerDashboardButton.Text = "Customer Dashboard";
            this.customerDashboardButton.UseVisualStyleBackColor = true;
            this.customerDashboardButton.Click += new System.EventHandler(this.customerDashboardButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphButton.ForeColor = System.Drawing.Color.White;
            this.graphButton.Location = new System.Drawing.Point(1092, 24);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(129, 63);
            this.graphButton.TabIndex = 9;
            this.graphButton.Text = "Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // addCriteriaBtn
            // 
            this.addCriteriaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCriteriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCriteriaBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCriteriaBtn.ForeColor = System.Drawing.Color.White;
            this.addCriteriaBtn.Location = new System.Drawing.Point(563, 24);
            this.addCriteriaBtn.Name = "addCriteriaBtn";
            this.addCriteriaBtn.Size = new System.Drawing.Size(152, 63);
            this.addCriteriaBtn.TabIndex = 10;
            this.addCriteriaBtn.Text = "Add Criteria";
            this.addCriteriaBtn.UseVisualStyleBackColor = true;
            this.addCriteriaBtn.Click += new System.EventHandler(this.addCriteriaBtn_Click);
            // 
            // viewReportBtn
            // 
            this.viewReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewReportBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportBtn.ForeColor = System.Drawing.Color.White;
            this.viewReportBtn.Location = new System.Drawing.Point(726, 24);
            this.viewReportBtn.Name = "viewReportBtn";
            this.viewReportBtn.Size = new System.Drawing.Size(152, 63);
            this.viewReportBtn.TabIndex = 11;
            this.viewReportBtn.Text = "View Report";
            this.viewReportBtn.UseVisualStyleBackColor = true;
            this.viewReportBtn.Click += new System.EventHandler(this.viewReportBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(620, 478);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 63);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bulkDataEntryBtn
            // 
            this.bulkDataEntryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bulkDataEntryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulkDataEntryBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkDataEntryBtn.ForeColor = System.Drawing.Color.White;
            this.bulkDataEntryBtn.Location = new System.Drawing.Point(889, 24);
            this.bulkDataEntryBtn.Name = "bulkDataEntryBtn";
            this.bulkDataEntryBtn.Size = new System.Drawing.Size(192, 63);
            this.bulkDataEntryBtn.TabIndex = 12;
            this.bulkDataEntryBtn.Text = "Bulk Data Entry";
            this.bulkDataEntryBtn.UseVisualStyleBackColor = true;
            this.bulkDataEntryBtn.Click += new System.EventHandler(this.bulkDataEntryBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 726);
            this.Controls.Add(this.bulkDataEntryBtn);
            this.Controls.Add(this.viewReportBtn);
            this.Controls.Add(this.addCriteriaBtn);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.customerDashboardButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerDashboardButton;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Button addCriteriaBtn;
        private System.Windows.Forms.Button viewReportBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button bulkDataEntryBtn;
    }
}