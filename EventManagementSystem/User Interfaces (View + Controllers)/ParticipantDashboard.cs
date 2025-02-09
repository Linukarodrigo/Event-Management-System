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
    public partial class ParticipantDashboard : Form
    {
        Person Person1;
        public ParticipantDashboard(Person person1)
        {
            InitializeComponent();
            Person1 = person1;
        }

        private void paticipantDashClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void participantLogOut_Click(object sender, EventArgs e)
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

        private void availableEventsBtn_Click(object sender, EventArgs e)
        {
            availableEvents1.Visible = true;
            eventBooking1.Visible = false;
        }

        private void eventRegisterBtn_Click(object sender, EventArgs e)
        {
            availableEvents1.Visible = false;
            eventBooking1.Visible = true;

        }
    }
}
