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
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showPwd_CheckedChanged(object sender, EventArgs e)
        {
            if(showPwd.Checked)
            {
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxt.UseSystemPasswordChar = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            IUserAuthentication userAuthentication = new PersonManager();
            Person personobj = userAuthentication.Login(usernameTxt.Text, passwordTxt.Text);

            if (personobj != null)
            {
                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                string role = personobj.GetRole().ToLower();

                if (role == "admin")
                {
                    // Navigate to the AdminDashboard
                    Form adminDash = new AdminDashboard(personobj);
                    adminDash.ShowDialog();
                }
                else if (role == "organizer")
                {
                    // Navigate to the OrganizerDashboard
                    Form organizerDash = new OrganizerDashboard(personobj);
                    organizerDash.ShowDialog();
                }
                else if (role == "participant")
                {
                    // Navigate to the ParticipantDashboard
                    Form participantDash = new ParticipantDashboard(personobj);
                    participantDash.ShowDialog();
                }            
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect. Please try again", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFormFields();
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void registerClick_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Navigate to the RegisterUI
            Form registerForm = new RegisterUI();
            registerForm.ShowDialog();

           
        }

        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearFormFields()
        {
            usernameTxt.Text = "";
            passwordTxt.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
