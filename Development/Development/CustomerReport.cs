using System;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

namespace Development
{
    public partial class CustomerReport : Form
    {

        public CustomerReport()
        {
            InitializeComponent();
        }

        DataView dataView;
        DataTable dataTable;

        public void GetCustomerReport()
        {
            try
            {
                // Adding columns in data table
                dataTable = new DataTable();
                dataTable.Columns.Add("SN");
                dataTable.Columns.Add("Service Name");
                dataTable.Columns.Add("Customer Name");
                dataTable.Columns.Add("Contact Number");
                dataTable.Columns.Add("Email Address");
                dataTable.Columns.Add("Address");
                dataTable.Columns.Add("Feedback");
                dataTable.Columns.Add("Date");
                dataTable.Columns.Add("Criteria");
                dataTable.Columns.Add("Criteria Value");

                DataSet dsRead = new DataSet();
                dsRead.ReadXmlSchema(@"../RatingsSchema.xml");
                dsRead.ReadXml(@"../RatingsData.xml");

                for (int i = 0; i < dsRead.Tables["Ratings"].Rows.Count; i++)
                {
                    // Adding value in data table
                    dataTable.Rows.Add(
                    i + 1,
                    dsRead.Tables["Ratings"].Rows[i][1].ToString(),
                    dsRead.Tables["Ratings"].Rows[i][2].ToString(),
                    dsRead.Tables["Ratings"].Rows[i][3].ToString(),
                    dsRead.Tables["Ratings"].Rows[i][4].ToString(),
                    dsRead.Tables["Ratings"].Rows[i][5].ToString(),
                    dsRead.Tables["Ratings"].Rows[i][6].ToString(),
                    dsRead.Tables["Ratings"].Rows[i][7].ToString(),
                    dsRead.Tables["Ratings"].Rows[i][8].ToString(),
                    dsRead.Tables["Ratings"].Rows[i][9].ToString());
                }

                dataView = new DataView(dataTable);

                // Displaying data in data grid view 
                customerReportTable.DataSource = dataView;
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("The ratings file cannot be found in the saved directory. Please verify it once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            GetCustomerReport();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
                DateTime startDate = start_dateTimePicker.Value.Date;
                DateTime endDate = end_dateTimePicker.Value.Date;
                dataView.RowFilter = String.Format("Date >= #{0:MM/dd/yyyy}# AND Date <= #{1:MM/dd/yyyy}#", startDate, endDate);
                customerReportTable.DataSource = dataView;

                if (customerReportTable.Rows.Count == 1)
            {
                MessageBox.Show("No customer report available from date: " + startDate.ToString("MM/dd/yyyy") + " to " + endDate.ToString("MM/dd/yyyy") + ".", "Customer Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
            {
                MessageBox.Show("Here are the customer report from date: " + startDate.ToString("MM/dd/yyyy") + " to " + endDate.ToString("MM/dd/yyyy") + ".", "Customer Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sortByDateButton_Click(object sender, EventArgs e)
        {
            if (customerReportTable.Rows.Count == 1)
            {
                MessageBox.Show("There are no data to sort.", "Data Sorting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.customerReportTable.Sort(customerReportTable.Columns["Date"], ListSortDirection.Ascending);
                MessageBox.Show("Reports are successfully sorted according to date.", "Customer Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void loadDefaultDataButton_Click(object sender, EventArgs e)
        {
            GetCustomerReport();
            MessageBox.Show("Default data are loaded successfully.", "Customer Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerReportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
