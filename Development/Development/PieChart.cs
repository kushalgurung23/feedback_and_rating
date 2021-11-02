using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Windows.Forms;

using System.Collections;

namespace Development
{
    public partial class PieChart : Form
    {

        public PieChart()
        {
            
            InitializeComponent();
            DisplayPieChart();
        }

        public void DisplayPieChart()
        {

            try
            {
                ArrayList criteriaArrayList = new ArrayList();
                ArrayList overallArrayList = new ArrayList();

                // Reading data from dataset
                DataSet dsRead = new DataSet();
                dsRead.ReadXmlSchema(@"../ReportSchema.xml");
                dsRead.ReadXml(@"../ReportData.xml");

                for (int i = 0; i < dsRead.Tables["Report"].Rows.Count; i++)
                {
                    // Criteria Name
                    criteriaArrayList.Add(dsRead.Tables["Report"].Rows[i][1].ToString());

                    // Overall Rating
                    overallArrayList.Add(dsRead.Tables["Report"].Rows[i][8].ToString());
                    chart2.Series[0].Points.AddXY(criteriaArrayList[i].ToString(), Convert.ToDouble(overallArrayList[i]));
                }

                this.chart2.Series[0]["PieLabelStyle"] = "Outside";

                // Set border width so that labels are shown on the outside
                this.chart2.Series[0].BorderWidth = 1;
                this.chart2.Series[0].BorderColor = Color.FromArgb(26, 59, 105);

                // Add a legend to the chart and dock it to the botton-center
                this.chart2.Legends[0].Enabled = true;
                this.chart2.Legends[0].Docking = Docking.Bottom;
                this.chart2.Legends[0].Alignment = StringAlignment.Center;

                // Set the legend to display pie chart values as percentages
                // Again, the P2 indicates a precision of 2 decimals
                this.chart2.Series[0].LegendText = "#PERCENT{P2}";

                // By sorting the data points, they show up in proper ascending order in the legend
                this.chart2.DataManipulator.Sort(PointSortOrder.Descending, chart2.Series[0]);

                //chart2.Series[0].ChartType = SeriesChartType.Column;
                chart2.Series[0].ChartType = SeriesChartType.Pie;

                chart2.Titles.Add("Overall rating of each criteria");
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("The Report file cannot be found in the saved directory. Please verify it once.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
