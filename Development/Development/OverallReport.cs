using System;
using System.Data;
using System.Windows.Forms;
using Handler;

namespace Development
{
    public partial class OverallReport : Form
    {
        public OverallReport()
        {
            InitializeComponent();
            getReportData();
        }

        void getReportData()
        {
            try
            {
                // Reading data from dataset
                DataSet dsRead = new DataSet();

                // For criteria
                dsRead.ReadXmlSchema(@"../CriteriaSchema.xml");
                dsRead.ReadXml(@"../CriteriaData.xml");

                // For Ratings
                dsRead.ReadXmlSchema(@"../RatingsSchema.xml");
                dsRead.ReadXml(@"../RatingsData.xml");

                if (dsRead.Tables["Criteria"] != null && dsRead.Tables["Ratings"] != null)
                {
                    for (int i = 0; i < dsRead.Tables["Criteria"].Rows.Count; i++)
                    {
                        reportTable.Rows.Add();
                        reportTable.Rows[i].Cells["snColumn"].Value = i + 1;
                        reportTable.Rows[i].Cells["criteriaColumn"].Value = dsRead.Tables["Criteria"].Rows[i][1].ToString();
                        reportTable.Rows[i].Cells["descriptionColumn"].Value = dsRead.Tables["Criteria"].Rows[i][2].ToString();

                        int excellentRating = 0;
                        int goodRating = 0;
                        int averageRating = 0;
                        int dissatisfiedRating = 0;

                        for (int j = 0; j < dsRead.Tables["Ratings"].Rows.Count; j++)
                        {
                            // If the data in Criteria column of Ratings table is equal to report table's Criteria column's data, then only the statement will be executed.
                            if (dsRead.Tables["Ratings"].Rows[j][8].ToString() == reportTable.Rows[i].Cells["criteriaColumn"].Value.ToString())
                            {
                                if (dsRead.Tables["Ratings"].Rows[j][9].ToString() == "5")
                                {
                                    reportTable.Rows[i].Cells["excellentColumn"].Value = Convert.ToString(Convert.ToInt32(reportTable.Rows[i].Cells["excellentColumn"].Value) + 1);
                                    excellentRating = excellentRating + 1;
                                }

                                else if (dsRead.Tables["Ratings"].Rows[j][9].ToString() == "3")
                                {
                                    reportTable.Rows[i].Cells["goodColumn"].Value = Convert.ToString(Convert.ToInt32(reportTable.Rows[i].Cells["goodColumn"].Value) + 1);
                                    goodRating = goodRating + 1;
                                }

                                else if (dsRead.Tables["Ratings"].Rows[j][9].ToString() == "2")
                                {
                                    reportTable.Rows[i].Cells["averageColumn"].Value = Convert.ToString(Convert.ToInt32(reportTable.Rows[i].Cells["averageColumn"].Value) + 1);
                                    averageRating = averageRating + 1;
                                }

                                else if (dsRead.Tables["Ratings"].Rows[j][9].ToString() == "1")
                                {
                                    reportTable.Rows[i].Cells["dissatisfiedColumn"].Value = Convert.ToString(Convert.ToInt32(reportTable.Rows[i].Cells["dissatisfiedColumn"].Value) + 1);
                                    dissatisfiedRating = dissatisfiedRating + 1;
                                }

                            }

                            // End of nested for loop
                        }

                        // End of main for loop
                    }
                }

                decimal excellent = 0;
                decimal good = 0;
                decimal average = 0;
                decimal dissatisfied = 0;

                for (int i = 0; i < reportTable.Rows.Count; i++)
                {
                    if (reportTable.Rows[i].Cells["excellentColumn"].Value == null)
                    {
                        reportTable.Rows[i].Cells["excellentColumn"].Value = 0;
                    }

                    if (reportTable.Rows[i].Cells["goodColumn"].Value == null)
                    {
                        reportTable.Rows[i].Cells["goodColumn"].Value = 0;
                    }

                    if (reportTable.Rows[i].Cells["averageColumn"].Value == null)
                    {
                        reportTable.Rows[i].Cells["averageColumn"].Value = 0;
                    }

                    if (reportTable.Rows[i].Cells["dissatisfiedColumn"].Value == null)
                    {
                        reportTable.Rows[i].Cells["dissatisfiedColumn"].Value = 0;
                    }

                    if (reportTable.Rows[i].Cells["meanColumn"].Value == null)
                    {
                        reportTable.Rows[i].Cells["meanColumn"].Value = 0;
                    }

                    if (reportTable.Rows[i].Cells["overallColumn"].Value == null)
                    {
                        reportTable.Rows[i].Cells["overallColumn"].Value = 0;
                    }

                    excellent = Convert.ToInt32(reportTable.Rows[i].Cells["excellentColumn"].Value.ToString());
                    good = Convert.ToInt32(reportTable.Rows[i].Cells["goodColumn"].Value.ToString());
                    average = Convert.ToInt32(reportTable.Rows[i].Cells["averageColumn"].Value.ToString());
                    dissatisfied = Convert.ToInt32(reportTable.Rows[i].Cells["dissatisfiedColumn"].Value.ToString());

                    try
                    {
                        if(excellent == 0 && good == 0 && average == 0 && dissatisfied == 0)
                        {
                            // If newly added criteria don't have any ratings (,i.e. 0 ratings), we cannot get mean rating, because we will get undefined value while dividing by zero.
                            // Hence, we will set mean ratings value to 0 by ourselves.
                            reportTable.Rows[i].Cells["meanColumn"].Value = 0;   
                        }

                        else
                        {
                            // We use String.Format() to get two decimal place value for our Mean Column
                            reportTable.Rows[i].Cells["meanColumn"].Value = String.Format("{0:.##}", ((excellent * 5) + (good * 3) + (average * 2) + (dissatisfied * 1)) / (excellent + good + average + dissatisfied)); 
                        }

                        // Overall Column
                        reportTable.Rows[i].Cells["overallColumn"].Value = ((excellent * 5) + (good * 3) + (average * 2) + (dissatisfied * 1));

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show(ex + "", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                    // For creating Report file
                    DataHandler dh = new DataHandler();
                    DataSet ds = new DataSet();
                    ds = dh.CreateDataSet();

                    AddSampleDataForReport(ds);
                    ds.WriteXmlSchema(@"../ReportSchema.xml");
                    ds.WriteXml(@"../ReportData.xml");
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Required files cannot be found in the saved directory. Please verify it once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex + "", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This method will now add all the overall data row in the dataset
        void AddSampleDataForReport(DataSet dataSet)
        {
            // Creating a new DataRow
            DataRow dr;

            for (int i = 0; i < reportTable.Rows.Count; i++)
            {
                // Adding new row in the Report table.
                dr = dataSet.Tables["Report"].NewRow();

                dr["Criteria"] = reportTable.Rows[i].Cells["criteriaColumn"].Value.ToString();
                dr["Description"] = reportTable.Rows[i].Cells["descriptionColumn"].Value.ToString();
                dr["Excellent"] = reportTable.Rows[i].Cells["excellentColumn"].Value.ToString();
                dr["Good"] = reportTable.Rows[i].Cells["goodColumn"].Value.ToString();
                dr["Average"] = reportTable.Rows[i].Cells["averageColumn"].Value.ToString();
                dr["Dissatisfied"] = reportTable.Rows[i].Cells["dissatisfiedColumn"].Value.ToString();
                dr["Mean"] = reportTable.Rows[i].Cells["meanColumn"].Value.ToString();
                dr["Overall"] = reportTable.Rows[i].Cells["overallColumn"].Value.ToString();

                dataSet.Tables["Report"].Rows.Add(dr);
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void reportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
