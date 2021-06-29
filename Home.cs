using System;
using System.Windows.Forms;

namespace Feedback_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminCheck ac = new AdminCheck();
            ac.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer cs = new Customer(false);
            cs.Show();
        }
    }
}
