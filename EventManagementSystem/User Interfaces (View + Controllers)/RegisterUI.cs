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
    public partial class RegisterUI : Form
    {
        public RegisterUI()
        {
            InitializeComponent();

            roleComboBox.Items.Add("Participant");
            roleComboBox.Items.Add("Organizer");

            roleComboBox.SelectedIndex = 0;
        }

        private void registerClick_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Navigate to the LoginUI
            Form loginForm = new LoginUI();
            loginForm.ShowDialog();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            IUserAuthentication userAuthentication = new PersonManager();

            string username = registerUsername.Text;
            string password = registerPassword.Text;
            string name = registerName.Text;
            string phoneNo = registerPhone.Text;
            string role = roleComboBox.Text;

            bool successRegister = userAuthentication.AddUser(username, password, name, phoneNo, role);

            if (successRegister)
            {
                ClearFormFields(); 
            }
            else
            {
                registerPhone.Text = ""; 
            }
        }

        private void ClearFormFields()
        {
            registerUsername.Text = "";
            registerPassword.Text = "";
            registerName.Text = "";
            registerPhone.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (registerShowPwd.Checked)
            {
                registerPassword.UseSystemPasswordChar = false;
            }
            else
            {
                registerPassword.UseSystemPasswordChar = true;
            }
        }

        private void registerPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
