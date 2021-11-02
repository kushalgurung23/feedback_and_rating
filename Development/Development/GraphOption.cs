using System;
using System.Windows.Forms;

namespace Development
{
    public partial class GraphOption : Form
    {
        public GraphOption()
        {
            InitializeComponent();
        }

        private void meanRatingButton_Click(object sender, EventArgs e)
        {
            BarGraph barGraph = new BarGraph();
            barGraph.Show();
        }

        private void overallRatingButton_Click(object sender, EventArgs e)
        {
            PieChart pieChart = new PieChart();
            pieChart.Show(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportOptionPanel_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
}
