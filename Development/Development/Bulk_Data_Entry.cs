using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Handler;

namespace Development
{
    public partial class Bulk_Data_Entry : Form
    {
        public Bulk_Data_Entry()
        {
            InitializeComponent();  
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            if (fileLocationTextBox.Text == "")
            {
                MessageBox.Show("Please select a bulk file.", "Bulk Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // file location will be passed into LoadCSV method to get data of csv file for displaying them in data grid view
                    bulkEntryDataGridView.DataSource = LoadCSV(fileLocationTextBox.Text);
                    MessageBox.Show("Bulk data loaded successfully.", "Bulk Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Please select the correct bulk file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } 
        }

        // returns list of data of csv file
        public List<Columns> LoadCSV(string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(',')
                        select new Columns
                        {
                            Service_Name = data[0],
                            Customer_Name = data[1],
                            Contact_Number = data[2],
                            Email_Address = data[3],
                            Address = data[4],
                            Feedback = data[5],
                            Date = data[6],
                            Criteria = data[7],
                            Criteria_Value = data[8],
                        };

            return query.ToList();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            fileLocationTextBox.Text = dialog.FileName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (fileLocationTextBox.Text == "")
                {
                    MessageBox.Show("Please select a bulk file.", "Bulk Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (fileLocationTextBox.Text != "" && bulkEntryDataGridView.DataSource == null)
                {
                    MessageBox.Show("Please display and check the bulk data before saving.", "Bulk Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (bulkEntryDataGridView.DataSource == null)
                {
                    MessageBox.Show("Please select the correct bulk file.", "Bulk Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    DataHandler dh = new DataHandler();
                    DataSet ds = new DataSet();
                    ds = dh.CreateDataSet();

                    AddSampleDataForRatings(ds);
                    ds.WriteXmlSchema(@"../RatingsSchema.xml");
                    ds.WriteXml(@"../RatingsData.xml");
                    MessageBox.Show("Bulk data are successfully saved into the system.", "Bulk Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fileLocationTextBox.Text = "";
                    bulkEntryDataGridView.DataSource = null;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Please select the correct file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void AddSampleDataForRatings(DataSet dataSet)
        {
            try
            {
                DataSet dsRead = new DataSet();
                dsRead.ReadXmlSchema(@"../RatingsSchema.xml");
                dsRead.ReadXml(@"../RatingsData.xml");

                DataRow dr;

                // If the data in Ratings table is not null, then only it's statement will be executed.
                if (dsRead.Tables["Ratings"] != null)
                {
                    // All the data from previous xml file will be added in the new xml file.
                    for (int i = 0; i < dsRead.Tables["Ratings"].Rows.Count; i++)
                    {
                        dr = dataSet.Tables["Ratings"].NewRow();

                        dr["Service Name"] = dsRead.Tables["Ratings"].Rows[i]["Service Name"].ToString();
                        dr["Customer Name"] = dsRead.Tables["Ratings"].Rows[i]["Customer Name"].ToString();
                        dr["Contact Number"] = dsRead.Tables["Ratings"].Rows[i]["Contact Number"].ToString();
                        dr["Email Address"] = dsRead.Tables["Ratings"].Rows[i]["Email Address"].ToString();
                        dr["Address"] = dsRead.Tables["Ratings"].Rows[i]["Address"].ToString();
                        dr["Feedback"] = dsRead.Tables["Ratings"].Rows[i]["Feedback"].ToString();
                        dr["Date"] = dsRead.Tables["Ratings"].Rows[i]["Date"].ToString();

                        dr["Criteria"] = dsRead.Tables["Ratings"].Rows[i]["Criteria"].ToString();
                        dr["Criteria Value"] = dsRead.Tables["Ratings"].Rows[i]["Criteria Value"].ToString();
                        dataSet.Tables["Ratings"].Rows.Add(dr);
                    }
                }

                // All the previous data are read. Now, this for loop will add all the new data of bulkEntryDataGridView into the Rating table.
                for (int i = 0; i < bulkEntryDataGridView.Rows.Count; i++)
                {
                    dr = dataSet.Tables["Ratings"].NewRow();
                    dr["Service Name"] = bulkEntryDataGridView.Rows[i].Cells[0].Value.ToString();
                    dr["Customer Name"] = bulkEntryDataGridView.Rows[i].Cells[1].Value.ToString();
                    dr["Contact Number"] = bulkEntryDataGridView.Rows[i].Cells[2].Value.ToString();
                    dr["Email Address"] = bulkEntryDataGridView.Rows[i].Cells[3].Value.ToString();
                    dr["Address"] = bulkEntryDataGridView.Rows[i].Cells[4].Value.ToString();
                    dr["Feedback"] = bulkEntryDataGridView.Rows[i].Cells[5].Value.ToString();
                    dr["Date"] = bulkEntryDataGridView.Rows[i].Cells[6].Value.ToString();

                    dr["Criteria"] = bulkEntryDataGridView.Rows[i].Cells[7].Value.ToString();
                    dr["Criteria Value"] = bulkEntryDataGridView.Rows[i].Cells[8].Value.ToString();
                    dataSet.Tables["Ratings"].Rows.Add(dr);
                }
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("The ratings file cannot be found in the saved directory. Please verify it once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Bulk_Data_Entry_Load(object sender, EventArgs e)
        {

        }

        private void bulkEntryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

    public class Columns
    {
        public string Service_Name { get; set; }

        public string Customer_Name { get; set; }

        public string Contact_Number { get; set; }

        public string Email_Address { get; set; }

        public string Address { get; set; }

        public string Feedback { get; set; }

        public string Date { get; set; }

        public string Criteria { get; set; }

        public string Criteria_Value { get; set; }
    }
}
