using Handler;
using System;
using System.Data;
using System.Windows.Forms;

namespace Development
{
    public partial class CriteriaAdd : Form
    {
        public CriteriaAdd()
        {
            InitializeComponent();
        }

        void SaveDataToFile()
        {
            DataHandler dh = new DataHandler();

            DataSet ds = new DataSet();

            ds = dh.CreateDataSet();
            AddSampleData(ds);
            ds.WriteXml(@"../CriteriaData.xml");
            ds.WriteXmlSchema(@"../CriteriaSchema.xml");
            
        }

        private void AddSampleData(DataSet dataSet)
        {
            try
            {
                DataSet dsRead = new DataSet();
                dsRead.ReadXml(@"../CriteriaData.xml");
                dsRead.ReadXmlSchema(@"../CriteriaSchema.xml");

                DataRow dr;

                // In for loop, rows will be added from our XML file. 
                if (dsRead.Tables["Criteria"] != null)
                {
                    for (int i = 0; i < dsRead.Tables["Criteria"].Rows.Count; i++)
                    {
                        dr = dataSet.Tables["Criteria"].NewRow();
                        dr["Criteria Name"] = dsRead.Tables["Criteria"].Rows[i]["Criteria Name"].ToString();
                        dr["Description"] = dsRead.Tables["Criteria"].Rows[i]["Description"].ToString();

                        dataSet.Tables["Criteria"].Rows.Add(dr);
                    }
                }

                //Here we will add rows based on what user enters.
                string criteriaName = "";
                string criteriaDescription = "";

                criteriaName = criteriaNameTextBox.Text;
                criteriaDescription = descriptionTextBox.Text;

                var dr1 = dataSet.Tables["Criteria"].NewRow();
                dr1["Criteria Name"] = criteriaName;
                dr1["Description"] = criteriaDescription;

                dataSet.Tables["Criteria"].Rows.Add(dr1);
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("The criteria file cannot be found in the saved directory. Please verify it once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void criteriaAddButton_Click_1(object sender, EventArgs e)
        {
            if (criteriaNameTextBox.Text == "" )
            {
                MessageBox.Show("Please provide criteria's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (descriptionTextBox.Text == "")
            {
                MessageBox.Show("Please provide criteria's description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SaveDataToFile();
                MessageBox.Show("New criteria added successfully.", "Criteria Addition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                criteriaNameTextBox.Text = "";
                descriptionTextBox.Text = "";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CriteriaAdd_Load(object sender, EventArgs e)
        {

        }

    }
}
