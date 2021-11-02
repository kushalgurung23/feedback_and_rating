
namespace Development
{
    partial class ReportOption
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
            this.overallReportButton = new System.Windows.Forms.Button();
            this.customerReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportOptionPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.reportOptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // overallReportButton
            // 
            this.overallReportButton.BackColor = System.Drawing.Color.DarkCyan;
            this.overallReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.overallReportButton.FlatAppearance.BorderSize = 0;
            this.overallReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overallReportButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallReportButton.ForeColor = System.Drawing.Color.White;
            this.overallReportButton.Location = new System.Drawing.Point(137, 193);
            this.overallReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.overallReportButton.Name = "overallReportButton";
            this.overallReportButton.Size = new System.Drawing.Size(225, 37);
            this.overallReportButton.TabIndex = 12;
            this.overallReportButton.Text = "2. Overall Report";
            this.overallReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overallReportButton.UseVisualStyleBackColor = false;
            this.overallReportButton.Click += new System.EventHandler(this.overallReportButton_Click);
            // 
            // customerReport
            // 
            this.customerReport.BackColor = System.Drawing.Color.DarkCyan;
            this.customerReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerReport.FlatAppearance.BorderSize = 0;
            this.customerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerReport.ForeColor = System.Drawing.Color.White;
            this.customerReport.Location = new System.Drawing.Point(137, 113);
            this.customerReport.Margin = new System.Windows.Forms.Padding(4);
            this.customerReport.Name = "customerReport";
            this.customerReport.Size = new System.Drawing.Size(225, 37);
            this.customerReport.TabIndex = 11;
            this.customerReport.Text = "1. Customer Report";
            this.customerReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerReport.UseVisualStyleBackColor = false;
            this.customerReport.Click += new System.EventHandler(this.customerReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Development.Properties.Resources.OIP1;
            this.pictureBox1.Location = new System.Drawing.Point(459, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose One:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportOptionPanel
            // 
            this.reportOptionPanel.BackColor = System.Drawing.Color.Teal;
            this.reportOptionPanel.Controls.Add(this.label1);
            this.reportOptionPanel.Controls.Add(this.pictureBox1);
            this.reportOptionPanel.Controls.Add(this.customerReport);
            this.reportOptionPanel.Controls.Add(this.overallReportButton);
            this.reportOptionPanel.Location = new System.Drawing.Point(-1, -1);
            this.reportOptionPanel.Name = "reportOptionPanel";
            this.reportOptionPanel.Size = new System.Drawing.Size(491, 291);
            this.reportOptionPanel.TabIndex = 0;
            this.reportOptionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.reportOptionPanel_Paint);
            // 
            // ReportOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 286);
            this.Controls.Add(this.reportOptionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportOption";
            this.Load += new System.EventHandler(this.ReportOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.reportOptionPanel.ResumeLayout(false);
            this.reportOptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button overallReportButton;
        private System.Windows.Forms.Button customerReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel reportOptionPanel;
    }
}