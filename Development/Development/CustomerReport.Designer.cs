
namespace Development
{
    partial class CustomerReport
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
            this.customerReportTable = new System.Windows.Forms.DataGridView();
            this.start_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.filterButton = new System.Windows.Forms.Button();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.sortByDateButton = new System.Windows.Forms.Button();
            this.loadDefaultDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // customerReportTable
            // 
            this.customerReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerReportTable.Location = new System.Drawing.Point(-3, 75);
            this.customerReportTable.Name = "customerReportTable";
            this.customerReportTable.RowHeadersWidth = 51;
            this.customerReportTable.RowTemplate.Height = 24;
            this.customerReportTable.Size = new System.Drawing.Size(1378, 565);
            this.customerReportTable.TabIndex = 0;
            this.customerReportTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerReportTable_CellContentClick);
            // 
            // start_dateTimePicker
            // 
            this.start_dateTimePicker.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_dateTimePicker.Location = new System.Drawing.Point(141, 34);
            this.start_dateTimePicker.Name = "start_dateTimePicker";
            this.start_dateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.start_dateTimePicker.TabIndex = 2;
            this.start_dateTimePicker.Value = new System.DateTime(2021, 1, 2, 0, 0, 0, 0);
            // 
            // end_dateTimePicker
            // 
            this.end_dateTimePicker.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_dateTimePicker.Location = new System.Drawing.Point(483, 31);
            this.end_dateTimePicker.Name = "end_dateTimePicker";
            this.end_dateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.end_dateTimePicker.TabIndex = 3;
            this.end_dateTimePicker.Value = new System.DateTime(2021, 1, 14, 0, 0, 0, 0);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Teal;
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.Location = new System.Drawing.Point(714, 25);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(159, 40);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateLabel.Location = new System.Drawing.Point(24, 36);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(97, 19);
            this.fromDateLabel.TabIndex = 5;
            this.fromDateLabel.Text = "From Date:";
            this.fromDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.Location = new System.Drawing.Point(385, 39);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(75, 19);
            this.toDateLabel.TabIndex = 6;
            this.toDateLabel.Text = "To Date:";
            // 
            // sortByDateButton
            // 
            this.sortByDateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sortByDateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortByDateButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByDateButton.ForeColor = System.Drawing.Color.White;
            this.sortByDateButton.Location = new System.Drawing.Point(919, 24);
            this.sortByDateButton.Name = "sortByDateButton";
            this.sortByDateButton.Size = new System.Drawing.Size(215, 40);
            this.sortByDateButton.TabIndex = 7;
            this.sortByDateButton.Text = "Sort By Date";
            this.sortByDateButton.UseVisualStyleBackColor = false;
            this.sortByDateButton.Click += new System.EventHandler(this.sortByDateButton_Click);
            // 
            // loadDefaultDataButton
            // 
            this.loadDefaultDataButton.BackColor = System.Drawing.Color.Navy;
            this.loadDefaultDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadDefaultDataButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDefaultDataButton.ForeColor = System.Drawing.Color.White;
            this.loadDefaultDataButton.Location = new System.Drawing.Point(1151, 24);
            this.loadDefaultDataButton.Name = "loadDefaultDataButton";
            this.loadDefaultDataButton.Size = new System.Drawing.Size(215, 40);
            this.loadDefaultDataButton.TabIndex = 9;
            this.loadDefaultDataButton.Text = "Load Default Data";
            this.loadDefaultDataButton.UseVisualStyleBackColor = false;
            this.loadDefaultDataButton.Click += new System.EventHandler(this.loadDefaultDataButton_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 664);
            this.Controls.Add(this.loadDefaultDataButton);
            this.Controls.Add(this.sortByDateButton);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.end_dateTimePicker);
            this.Controls.Add(this.start_dateTimePicker);
            this.Controls.Add(this.customerReportTable);
            this.Name = "CustomerReport";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerReportTable;
        private System.Windows.Forms.DateTimePicker start_dateTimePicker;
        private System.Windows.Forms.DateTimePicker end_dateTimePicker;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.Button sortByDateButton;
        private System.Windows.Forms.Button loadDefaultDataButton;
    }
}