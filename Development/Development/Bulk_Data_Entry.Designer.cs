
namespace Development
{
    partial class Bulk_Data_Entry
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
            this.loadDataButton = new System.Windows.Forms.Button();
            this.bulkEntryDataGridView = new System.Windows.Forms.DataGridView();
            this.fileLocationTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bulkEntryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadDataButton
            // 
            this.loadDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loadDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadDataButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDataButton.ForeColor = System.Drawing.Color.White;
            this.loadDataButton.Location = new System.Drawing.Point(997, 19);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(246, 58);
            this.loadDataButton.TabIndex = 0;
            this.loadDataButton.Text = "Display Bulk Data";
            this.loadDataButton.UseVisualStyleBackColor = false;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // bulkEntryDataGridView
            // 
            this.bulkEntryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bulkEntryDataGridView.Location = new System.Drawing.Point(0, 83);
            this.bulkEntryDataGridView.Name = "bulkEntryDataGridView";
            this.bulkEntryDataGridView.RowHeadersWidth = 51;
            this.bulkEntryDataGridView.RowTemplate.Height = 24;
            this.bulkEntryDataGridView.Size = new System.Drawing.Size(1264, 406);
            this.bulkEntryDataGridView.TabIndex = 1;
            this.bulkEntryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bulkEntryDataGridView_CellContentClick);
            // 
            // fileLocationTextBox
            // 
            this.fileLocationTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLocationTextBox.Location = new System.Drawing.Point(29, 33);
            this.fileLocationTextBox.Name = "fileLocationTextBox";
            this.fileLocationTextBox.Size = new System.Drawing.Size(780, 32);
            this.fileLocationTextBox.TabIndex = 2;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Navy;
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(831, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(139, 58);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Teal;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(519, 510);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(194, 54);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Into System";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Bulk_Data_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 582);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileLocationTextBox);
            this.Controls.Add(this.bulkEntryDataGridView);
            this.Controls.Add(this.loadDataButton);
            this.Name = "Bulk_Data_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk_Data_Entry";
            this.Load += new System.EventHandler(this.Bulk_Data_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bulkEntryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.DataGridView bulkEntryDataGridView;
        private System.Windows.Forms.TextBox fileLocationTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button saveButton;
    }
}