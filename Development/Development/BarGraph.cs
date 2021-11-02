using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace Development
{
    public partial class BarGraph : Form
    {
        public BarGraph()
        {
            InitializeComponent();
            DisplayBarGraph();
        }

        public void DisplayBarGraph()
        {
            try
            {
                ArrayList criteriaArrayList = new ArrayList();
                ArrayList meanArrayList = new ArrayList();

                //reading data from xml and schema files
                DataSet dsRead = new DataSet();
                dsRead.ReadXmlSchema(@"../ReportSchema.xml");
                dsRead.ReadXml(@"../ReportData.xml");

                if (dsRead.Tables["Report"] != null)
                {
                    for (int i = 0; i < dsRead.Tables["Report"].Rows.Count; i++)
                    {
                        // Criteria Name
                        criteriaArrayList.Add(dsRead.Tables["Report"].Rows[i][1].ToString());

                        // Mean Rating
                        meanArrayList.Add(dsRead.Tables["Report"].Rows[i][7].ToString());
                    }
                }   

                // Setting title of the bar graph
                this.chart2.Titles.Add("Mean rating of each criteria");


                // Seting Color Palette for the bar graph
                this.chart2.Palette = ChartColorPalette.BrightPastel;

                // Add Series
                for (int i = 0; i < dsRead.Tables["Report"].Rows.Count; i++)
                {
                    // Series represents the data points and series attributes to store
                    // Adding series attributes
                    Series series = this.chart2.Series.Add(criteriaArrayList[i].ToString());

                    // Adding data point
                    series.Points.Add(Convert.ToDouble(meanArrayList[i]));
                }
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("The report file for mean rating cannot be found in the saved directory. Please verify it once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BarGraph_Load(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
