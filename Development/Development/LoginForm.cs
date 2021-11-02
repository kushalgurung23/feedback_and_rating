using System;
using System.Windows.Forms;
using System.Threading;

namespace Development
{
    public partial class LoginForm : Form
    {
        Thread thread;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Defining username and password.
            string username = "Kushal";
            string password = "Gurung";

            if (usernameTextBox.Text == username && passwordTextBox.Text == password)
            {
                MessageBox.Show("Welcome Admin, " + username+".", "Rating and Feedback System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();  
            }
            else
            {
                if (usernameTextBox.Text == "" && passwordTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Username and Password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (usernameTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Your Username.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (passwordTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Your Password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Username and Password doesn't match.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Text = "";
                    usernameTextBox.Focus();
                    passwordTextBox.Text = "";
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Customer Dashboard button
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Closing the current running form, and callng OpenCustomerUI method.
            this.Close();
            thread = new Thread(OpenCustomerUI);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static void OpenCustomerUI()
        {
            // It will run the new form, i.e. CustomerUI.
            Application.Run(new CustomerUI());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
