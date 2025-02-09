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
    public partial class AvailableEvents : UserControl
    {
        public AvailableEvents()
        {
            InitializeComponent();

            availableEventsGridView.ColumnCount = 8;
            availableEventsGridView.Columns[0].Name = "EventID";
            availableEventsGridView.Columns[1].Name = "EventName";
            availableEventsGridView.Columns[2].Name = "Description";
            availableEventsGridView.Columns[3].Name = "Venue";
            availableEventsGridView.Columns[4].Name = "EventDate";
            availableEventsGridView.Columns[5].Name = "OrganizerID";
            availableEventsGridView.Columns[6].Name = "OrganizerName";
            availableEventsGridView.Columns[7].Name = "MaxParticipants";

            EventManager fetchEventsToGrid = new EventManager();
            fetchEventsToGrid.fetchEventRecords(availableEventsGridView);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
