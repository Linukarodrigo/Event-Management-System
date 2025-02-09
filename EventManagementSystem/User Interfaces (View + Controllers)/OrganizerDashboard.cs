using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class OrganizerDashboard : Form
    {
        public Person Person1;
        public OrganizerDashboard(Person person1)
        {
            InitializeComponent();
            Person1 = person1;
        }

        private void registerClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminLogOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout ? ", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                // Navigate to the LoginUI
                Form loginForm = new LoginUI();
                loginForm.Show();

                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void oraganizerManageEventsBtn_Click(object sender, EventArgs e)
        {
            organizerManageEvents1.Visible = true;
            organizerManageBookings1.Visible = false;
        }

        private void organizerBookingsBtn_Click(object sender, EventArgs e)
        {
            organizerManageEvents1.Visible = false;
            organizerManageBookings1.Visible = true;
        }
    }
}
