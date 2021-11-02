namespace Development
{
    partial class CriteriaAdd
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
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.criteriaNameTextBox = new System.Windows.Forms.TextBox();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.criteriaDescLabel = new System.Windows.Forms.Label();
            this.criteriaAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(327, 83);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(258, 85);
            this.descriptionTextBox.TabIndex = 21;
            this.descriptionTextBox.Text = "";
            // 
            // criteriaNameTextBox
            // 
            this.criteriaNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaNameTextBox.Location = new System.Drawing.Point(327, 27);
            this.criteriaNameTextBox.Name = "criteriaNameTextBox";
            this.criteriaNameTextBox.Size = new System.Drawing.Size(258, 28);
            this.criteriaNameTextBox.TabIndex = 20;
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.serviceNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameLabel.ForeColor = System.Drawing.Color.Black;
            this.serviceNameLabel.Location = new System.Drawing.Point(98, 27);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(150, 23);
            this.serviceNameLabel.TabIndex = 19;
            this.serviceNameLabel.Text = "Criteria Name:";
            // 
            // criteriaDescLabel
            // 
            this.criteriaDescLabel.AutoSize = true;
            this.criteriaDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.criteriaDescLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaDescLabel.ForeColor = System.Drawing.Color.Black;
            this.criteriaDescLabel.Location = new System.Drawing.Point(98, 84);
            this.criteriaDescLabel.Name = "criteriaDescLabel";
            this.criteriaDescLabel.Size = new System.Drawing.Size(196, 23);
            this.criteriaDescLabel.TabIndex = 22;
            this.criteriaDescLabel.Text = "Criteria Description:";
            // 
            // criteriaAddButton
            // 
            this.criteriaAddButton.BackColor = System.Drawing.Color.Teal;
            this.criteriaAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.criteriaAddButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaAddButton.ForeColor = System.Drawing.Color.White;
            this.criteriaAddButton.Location = new System.Drawing.Point(277, 206);
            this.criteriaAddButton.Name = "criteriaAddButton";
            this.criteriaAddButton.Size = new System.Drawing.Size(162, 61);
            this.criteriaAddButton.TabIndex = 25;
            this.criteriaAddButton.Text = "ADD";
            this.criteriaAddButton.UseVisualStyleBackColor = false;
            this.criteriaAddButton.Click += new System.EventHandler(this.criteriaAddButton_Click_1);
            // 
            // CriteriaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Development.Properties.Resources.istockphoto_800330186_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 294);
            this.Controls.Add(this.criteriaAddButton);
            this.Controls.Add(this.criteriaDescLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.criteriaNameTextBox);
            this.Controls.Add(this.serviceNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "CriteriaAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Criteria Form";
            this.Load += new System.EventHandler(this.CriteriaAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.TextBox criteriaNameTextBox;
        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.Label criteriaDescLabel;
        private System.Windows.Forms.Button criteriaAddButton;
    }
}