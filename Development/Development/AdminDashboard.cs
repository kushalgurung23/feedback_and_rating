using System;
using System.Windows.Forms;
using System.Threading;

namespace Development
{
    public partial class AdminDashboard : Form
    {
        Thread thread;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        // Add Criteria button
        private void addCriteriaBtn_Click(object sender, EventArgs e)
        {
            CriteriaAdd criteriaAdd = new CriteriaAdd();
            criteriaAdd.Show();
        }

        // View Report button
        private void viewReportBtn_Click(object sender, EventArgs e)
        {
            ReportOption reportOption = new ReportOption();
            reportOption.Show();
        }

        // Graph button
        private void graphButton_Click(object sender, EventArgs e)
        {
            GraphOption graphOption = new GraphOption();
            graphOption.Show();
        }

        // Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sign Out button
        private void signOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully signed out.", "Rating and Feedback System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Closing the current running form, and callng OpenLoginForm method.
            this.Close(); 
            thread = new Thread(OpenLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        // Opens Admin Login UI
        public static void OpenLoginForm()
        {
            // It will run the LoginForm.
            Application.Run(new LoginForm());
        }

        // Opens Bulk Data Entry form
        private void bulkDataEntryBtn_Click(object sender, EventArgs e)
        {
            Bulk_Data_Entry bulk_Data_Entry = new Bulk_Data_Entry();
            bulk_Data_Entry.Show();
        }

        // Closes the current running form, and calls OpenCustomerUI method.
        private void customerDashboardButton_Click(object sender, EventArgs e)
        {   
            this.Close();
            thread = new Thread(OpenCustomerUI);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        // Opens Customer Rating and Feedback Dashboard
        public static void OpenCustomerUI()
        {  
            Application.Run(new CustomerUI()); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
