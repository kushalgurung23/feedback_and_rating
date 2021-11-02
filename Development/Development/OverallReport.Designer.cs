
namespace Development
{
    partial class OverallReport
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
            this.reportTable = new System.Windows.Forms.DataGridView();
            this.snColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criteriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excellentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dissatisfiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTable
            // 
            this.reportTable.AllowUserToAddRows = false;
            this.reportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snColumn,
            this.criteriaColumn,
            this.descriptionColumn,
            this.excellentColumn,
            this.goodColumn,
            this.averageColumn,
            this.dissatisfiedColumn,
            this.meanColumn,
            this.overallColumn});
            this.reportTable.Location = new System.Drawing.Point(0, 0);
            this.reportTable.Name = "reportTable";
            this.reportTable.RowHeadersWidth = 51;
            this.reportTable.RowTemplate.Height = 24;
            this.reportTable.Size = new System.Drawing.Size(1378, 386);
            this.reportTable.TabIndex = 0;
            this.reportTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportTable_CellContentClick);
            // 
            // snColumn
            // 
            this.snColumn.HeaderText = "SN";
            this.snColumn.MinimumWidth = 6;
            this.snColumn.Name = "snColumn";
            this.snColumn.Width = 40;
            // 
            // criteriaColumn
            // 
            this.criteriaColumn.HeaderText = "Criteria";
            this.criteriaColumn.MinimumWidth = 6;
            this.criteriaColumn.Name = "criteriaColumn";
            this.criteriaColumn.Width = 160;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.MinimumWidth = 6;
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.Width = 200;
            // 
            // excellentColumn
            // 
            this.excellentColumn.HeaderText = "Excellent";
            this.excellentColumn.MinimumWidth = 6;
            this.excellentColumn.Name = "excellentColumn";
            this.excellentColumn.Width = 90;
            // 
            // goodColumn
            // 
            this.goodColumn.HeaderText = "Good";
            this.goodColumn.MinimumWidth = 6;
            this.goodColumn.Name = "goodColumn";
            this.goodColumn.Width = 90;
            // 
            // averageColumn
            // 
            this.averageColumn.HeaderText = "Average";
            this.averageColumn.MinimumWidth = 6;
            this.averageColumn.Name = "averageColumn";
            this.averageColumn.Width = 90;
            // 
            // dissatisfiedColumn
            // 
            this.dissatisfiedColumn.HeaderText = "Dissatisfied";
            this.dissatisfiedColumn.MinimumWidth = 6;
            this.dissatisfiedColumn.Name = "dissatisfiedColumn";
            this.dissatisfiedColumn.Width = 90;
            // 
            // meanColumn
            // 
            this.meanColumn.HeaderText = "Mean";
            this.meanColumn.MinimumWidth = 6;
            this.meanColumn.Name = "meanColumn";
            this.meanColumn.Width = 125;
            // 
            // overallColumn
            // 
            this.overallColumn.HeaderText = "Overall";
            this.overallColumn.MinimumWidth = 6;
            this.overallColumn.Name = "overallColumn";
            this.overallColumn.Width = 125;
            // 
            // OverallReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 386);
            this.Controls.Add(this.reportTable);
            this.Name = "OverallReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overall Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn snColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criteriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn excellentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dissatisfiedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallColumn;
    }
}