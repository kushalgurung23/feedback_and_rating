using System;
using System.Data;
using System.Windows.Forms;
using Handler;
using System.Threading;

namespace Development
{
    public partial class CustomerUI : Form
    {
        Thread thread;
        public CustomerUI()
        {
            InitializeComponent();
            getCriteriaData();
        }

        //When one checkbox is selected in a row, another will be unselected
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;

            for (int i = 3; i<=6; i++)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)gridView.Rows[e.RowIndex].Cells[i];
                if( i != e.ColumnIndex)
                {
                    checkBoxCell.Value = checkBoxCell.FalseValue;
                }

            }

        }

        // Submit button
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isColumnEmpty = true;

                if (isColumnEmpty == true)
                {
                    // If all of the checkboxes of a row are unselected, isColumnEmpty will be set to false.
                    for (int i = 0; i < ratingTable.Rows.Count; i++)
                    {
                        if (ratingTable.Rows[i].Cells[3].Value == null && ratingTable.Rows[i].Cells[4].Value == null && ratingTable.Rows[i].Cells[5].Value == null && ratingTable.Rows[i].Cells[6].Value == null)
                        {
                            isColumnEmpty = false;
                        }

                    }
                }

                if (serviceNameComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select the service.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (isColumnEmpty == false)
                {
                    MessageBox.Show("Please give ratings to all the criteria.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    submitRatingsData();
                    MessageBox.Show("Thank you for your rating and feedback.", "Rating and Feedback System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // After rating is submitted, textboxes will be set to ""
                    customerNameTextBox.Text = "";
                    contactNumberTextBox.Text = "";
                    emailAddressTextBox.Text = "";
                    addressTextBox.Text = "";
                    feedbackTextBox.Text = "";

                    // After the ratings are submitted, all the checkbox values will be set to null.
                    for (int i = 0; i < ratingTable.Rows.Count; i++)
                    {
                        if (ratingTable.Rows[i].Cells[3].Value != null)
                        {
                            ratingTable.Rows[i].Cells[3].Value = null;
                        }

                        if (ratingTable.Rows[i].Cells[4].Value != null)
                        {
                            ratingTable.Rows[i].Cells[4].Value = null;
                        }

                        if (ratingTable.Rows[i].Cells[5].Value != null)
                        {
                            ratingTable.Rows[i].Cells[5].Value = null;
                        }

                        if (ratingTable.Rows[i].Cells[6].Value != null)
                        {
                            ratingTable.Rows[i].Cells[6].Value = null;
                        }

                        // End of for loop
                    }

                    // End of else statement
                }
            }

            catch (Exception ex)
            { 
                MessageBox.Show(ex+"", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // This method will retrieve criteria data from xml file.
        void getCriteriaData()
        {
            //reading data from dataset

            try
            {
                DataSet dsRead = new DataSet();
                dsRead.ReadXmlSchema(@"../CriteriaSchema.xml");
                dsRead.ReadXml(@"../CriteriaData.xml");

                if (dsRead.Tables["Criteria"] != null)
                {
                    for (int i = 0; i < dsRead.Tables["Criteria"].Rows.Count; i++)
                    {
                        ratingTable.Rows.Add();
                        ratingTable.Rows[i].Cells["snColumn"].Value = i + 1;
                        ratingTable.Rows[i].Cells["criteriaColumn"].Value = dsRead.Tables["Criteria"].Rows[i][1].ToString();
                        ratingTable.Rows[i].Cells["descriptionColumn"].Value = dsRead.Tables["Criteria"].Rows[i][2].ToString();
                    }
                }
                    
            }
            
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("The criteria file cannot be found in the saved directory. Please verify it once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // This method will be called when submit button is clicked.
        void submitRatingsData()
        {
            // Writing data into XML file
            DataHandler dh = new DataHandler();
            DataSet ds = new DataSet();
            ds = dh.CreateDataSet();

            AddSampleDataForRatings(ds);
            ds.WriteXmlSchema(@"../RatingsSchema.xml");
            ds.WriteXml(@"../RatingsData.xml");
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

                //for loop is run from the criteria that we read from criteria xml file.
                for (int i = 0; i < ratingTable.Rows.Count; i++)
                {
                    //criteria variable will store the criteria name from ratingTable DataGridView
                    string criteria;
                    criteria = ratingTable.Rows[i].Cells["criteriaColumn"].Value.ToString();

                    string CriteriaValue = "0";

                    string Excellent;
                    string Good;
                    string Average;
                    string Dissatisfied;

                    //
                    if (ratingTable.Rows[i].Cells[3].Value != null)
                    {
                        Excellent = ratingTable.Rows[i].Cells[3].Value.ToString();
                        if (Excellent == "True")
                        {
                            CriteriaValue = "5";
                        }
                    }

                    if (ratingTable.Rows[i].Cells[4].Value != null)
                    {
                        Good = ratingTable.Rows[i].Cells[4].Value.ToString();
                        if (Good == "True")
                        {
                            CriteriaValue = "3";
                        }
                    }

                    if (ratingTable.Rows[i].Cells[5].Value != null)
                    {
                        Average = ratingTable.Rows[i].Cells[5].Value.ToString();
                        if (Average == "True")
                        {
                            CriteriaValue = "2";
                        }
                    }

                    if (ratingTable.Rows[i].Cells[6].Value != null)
                    {
                        Dissatisfied = ratingTable.Rows[i].Cells[6].Value.ToString();
                        if (Dissatisfied == "True")
                        {
                            CriteriaValue = "1";
                        }
                    }

                    // Adding new row in the Ratings table.
                    dr = dataSet.Tables["Ratings"].NewRow();

                    dr["Service Name"] = serviceNameComboBox.SelectedItem.ToString();
                    dr["Customer Name"] = customerNameTextBox.Text;
                    dr["Contact Number"] = contactNumberTextBox.Text;
                    dr["Email Address"] = emailAddressTextBox.Text;
                    dr["Address"] = addressTextBox.Text;
                    dr["Feedback"] = feedbackTextBox.Text;
                    dr["Date"] = dateTimePicker.Value.ToString("MM/dd/yyyy");

                    dr["Criteria"] = criteria;
                    dr["Criteria Value"] = CriteriaValue;
                    dataSet.Tables["Ratings"].Rows.Add(dr);

                    // End of for loop       
                }
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("The ratings file cannot be found in the saved directory. Please verify it once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex+"", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginAsAdminButton_Click(object sender, EventArgs e)
        {
            // Closing the current running form, and callng OpenLoginForm method.
            this.Close();
            thread = new Thread(OpenLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static void OpenLoginForm()
        {
            // It will run the new form, i.e. LoginForm.
            Application.Run(new LoginForm());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void adminLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {

        }

    }
}
