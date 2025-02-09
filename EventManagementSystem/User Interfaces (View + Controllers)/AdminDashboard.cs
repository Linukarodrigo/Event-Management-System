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
    public partial class AdminDashboard : Form
    {
        public Person Person1;
        public AdminDashboard(Person Person1)
        {
            InitializeComponent();
            this.Person1 = Person1;
        }

        private void registerClose_Click(object sender, EventArgs e)
        {

        }

        private void registerClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageEvents1.Visible = false;
            manageParticipants1.Visible = true;
            manageOrganizers1.Visible = false;
            manageBookings1.Visible = false;

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

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

        private void manageEventsBtn_Click(object sender, EventArgs e)
        {
            manageEvents1.Visible = true;
            manageParticipants1.Visible = false;
            manageOrganizers1.Visible = false;
            manageBookings1.Visible = false;
            

        }

        private void viewBookingsBtn_Click(object sender, EventArgs e)
        {
            manageEvents1.Visible = false;
            manageParticipants1.Visible = false;
            manageOrganizers1.Visible = false;
            manageBookings1.Visible = true;
            

        }

        private void manageOrganizersBtn_Click(object sender, EventArgs e)
        {
            manageEvents1.Visible = false;
            manageParticipants1.Visible = false;
            manageOrganizers1.Visible = true;
            manageBookings1.Visible = false;

        }

        private void manageEvents1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
