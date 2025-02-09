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
    public partial class ManageOrganizers : UserControl
    {
        public Person Person1;
        public ManageOrganizers(Person person1)
        {
            InitializeComponent();
            this.Person1 = person1;
        }

        
        public ManageOrganizers()
        {
            InitializeComponent();

            organizerGridView.ColumnCount = 4;
            organizerGridView.Columns[0].Name = "OrganizerID";
            organizerGridView.Columns[1].Name = "Username";
            organizerGridView.Columns[2].Name = "Name";
            organizerGridView.Columns[3].Name = "PhoneNo";

            PersonManager fetchOrganizerToGrid = new PersonManager();
            fetchOrganizerToGrid.fetchOrganizerRecords(organizerGridView);
            
        }

        private void organizerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = organizerGridView.Rows[e.RowIndex];
                organizerIDTxt.Text = row.Cells[0].Value.ToString();
                organizerUsernameTxt.Text = row.Cells[1].Value.ToString();
                organizerNameTxt.Text = row.Cells[2].Value.ToString();
                organizerPhoneNoTxt.Text = row.Cells[3].Value.ToString();

            }
        }

        private void organizerRemoveBtn_Click(object sender, EventArgs e)
        {
            // Check if the text fields are empty (meaning no row was selected)
            if (string.IsNullOrEmpty(organizerIDTxt.Text) || string.IsNullOrEmpty(organizerNameTxt.Text) || string.IsNullOrEmpty(organizerPhoneNoTxt.Text))
            {

                MessageBox.Show("Please click a row in the table to select an organizer.", "No Organizer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PersonManager organizerRemove = new PersonManager();

            int OrganizerID = int.Parse(organizerIDTxt.Text);
            string OrganizerName = organizerNameTxt.Text;


            organizerRemove.RemoveOrganizers(OrganizerID, OrganizerName);

            ClearFormFields();

            RefreshOrganizerGrid();
        }

        private void ClearFormFields()
        {
            organizerIDTxt.Text = "";
            organizerUsernameTxt.Text = "";
            organizerNameTxt.Text = "";
            organizerPhoneNoTxt.Text = "";
        }

        private void RefreshOrganizerGrid()
        {
            // Clear the current rows in the DataGridView
            organizerGridView.Rows.Clear();

            // Fetch the updated event records
            PersonManager fetchOrganizersToGrid = new PersonManager();
            fetchOrganizersToGrid.fetchOrganizerRecords(organizerGridView);
        }
    }
}
