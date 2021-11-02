
namespace Development
{
    partial class GraphOption
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
            this.reportOptionPanel = new System.Windows.Forms.Panel();
            this.overallRatingButton = new System.Windows.Forms.Button();
            this.meanRatingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportOptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportOptionPanel
            // 
            this.reportOptionPanel.BackColor = System.Drawing.Color.Teal;
            this.reportOptionPanel.Controls.Add(this.overallRatingButton);
            this.reportOptionPanel.Controls.Add(this.meanRatingButton);
            this.reportOptionPanel.Controls.Add(this.label1);
            this.reportOptionPanel.Controls.Add(this.pictureBox1);
            this.reportOptionPanel.Location = new System.Drawing.Point(-1, -1);
            this.reportOptionPanel.Name = "reportOptionPanel";
            this.reportOptionPanel.Size = new System.Drawing.Size(494, 291);
            this.reportOptionPanel.TabIndex = 1;
            this.reportOptionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.reportOptionPanel_Paint);
            // 
            // overallRatingButton
            // 
            this.overallRatingButton.BackColor = System.Drawing.Color.DarkCyan;
            this.overallRatingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.overallRatingButton.FlatAppearance.BorderSize = 0;
            this.overallRatingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overallRatingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallRatingButton.ForeColor = System.Drawing.Color.White;
            this.overallRatingButton.Location = new System.Drawing.Point(137, 198);
            this.overallRatingButton.Margin = new System.Windows.Forms.Padding(4);
            this.overallRatingButton.Name = "overallRatingButton";
            this.overallRatingButton.Size = new System.Drawing.Size(225, 37);
            this.overallRatingButton.TabIndex = 16;
            this.overallRatingButton.Text = "2. Overall Rating";
            this.overallRatingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overallRatingButton.UseVisualStyleBackColor = false;
            this.overallRatingButton.Click += new System.EventHandler(this.overallRatingButton_Click);
            // 
            // meanRatingButton
            // 
            this.meanRatingButton.BackColor = System.Drawing.Color.DarkCyan;
            this.meanRatingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meanRatingButton.FlatAppearance.BorderSize = 0;
            this.meanRatingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meanRatingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanRatingButton.ForeColor = System.Drawing.Color.White;
            this.meanRatingButton.Location = new System.Drawing.Point(137, 114);
            this.meanRatingButton.Margin = new System.Windows.Forms.Padding(4);
            this.meanRatingButton.Name = "meanRatingButton";
            this.meanRatingButton.Size = new System.Drawing.Size(225, 37);
            this.meanRatingButton.TabIndex = 15;
            this.meanRatingButton.Text = "1. Mean Rating";
            this.meanRatingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meanRatingButton.UseVisualStyleBackColor = false;
            this.meanRatingButton.Click += new System.EventHandler(this.meanRatingButton_Click);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Development.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(459, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GraphOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 287);
            this.Controls.Add(this.reportOptionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraphOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Option";
            this.reportOptionPanel.ResumeLayout(false);
            this.reportOptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel reportOptionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button meanRatingButton;
        private System.Windows.Forms.Button overallRatingButton;
    }
}