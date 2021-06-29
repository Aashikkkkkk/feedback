using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback_System
{
    public partial class AdminCheck : Form
    {
        public AdminCheck()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text.ToLower();
            string password = txtPassword.Text;

            if (name.Equals(" ") && password.Equals(" "))
            {
                MessageBox.Show("Error: Incomplete information.");
            }
            else if (name != "admin")
            {
                MessageBox.Show("Error: Invalid UserName");
            }
            else if (password != "123")
            {
                MessageBox.Show("Error: Invalid Password");
            }
            else
            {
                MessageBox.Show("Successful");
                this.Hide();
                AdminForm ad = new AdminForm();
                ad.Show();
            }
        }
    }
}
