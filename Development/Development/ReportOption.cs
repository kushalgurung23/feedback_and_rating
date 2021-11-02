using System;
using System.Windows.Forms;

namespace Development
{
    public partial class ReportOption : Form
    {
        public ReportOption()
        {
            InitializeComponent();
        }

        private void ReportOption_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerReport_Click(object sender, EventArgs e)
        {
            CustomerReport customerReport = new CustomerReport();
            customerReport.Show();
        }

        private void overallReportButton_Click(object sender, EventArgs e)
        {
            OverallReport overallReport = new OverallReport();
            overallReport.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportOptionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
