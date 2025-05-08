using System;
using System.Windows.Forms;
using Eventology.Models.Management;

namespace Eventology.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            LoadSummaryData();
            LoadUpcomingEvents();
        }

        private void LoadSummaryData()
        {
            labelEvents.Text = EventsOrm.GetTotalEvents().ToString();
            labelUsers.Text = UsersOrm.GetTotalUsers().ToString();

            var roomStats = RoomsOrm.GetRoomAvailability();
            labelRoomsDisponible.Text = $"{roomStats.Available}/{roomStats.Occupied}";

            labelSoldTickets.Text = TicketsOrm.GetTotalSoldTickets().ToString();
        }

        private void LoadUpcomingEvents()
        {
            var upcomingEvents = EventsOrm.GetUpcomingEvents(5);
            dataGridViewEvents.DataSource = upcomingEvents;
            dataGridViewEvents.ReadOnly = true;
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewEvents.Columns.Contains("id"))
                dataGridViewEvents.Columns["id"].Visible = false;
        }
    }
}