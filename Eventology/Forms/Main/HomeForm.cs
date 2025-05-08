using System;
using System.Windows.Forms;
using Eventology.Models.Management;

/// <summary>
/// Home dashboard form for Eventology.
/// Displays key summary metrics and a list of upcoming events.
/// </summary>
namespace Eventology.Forms
{
    public partial class HomeForm : Form
    {
        /// <summary>
        /// Initializes the Home form and loads summary and upcoming events data.
        /// </summary>
        public HomeForm()
        {
            InitializeComponent();
            LoadSummaryData();
            LoadUpcomingEvents();
        }

        /// <summary>
        /// Loads and displays key summary data:
        /// - Total events
        /// - Total users
        /// - Room availability (available/occupied)
        /// - Total sold tickets
        /// </summary>
        private void LoadSummaryData()
        {
            // Get total number of events
            labelEvents.Text = EventsOrm.GetTotalEvents().ToString();

            // Get total number of users
            labelUsers.Text = UsersOrm.GetTotalUsers().ToString();

            // Get room availability stats (available/occupied)
            var roomStats = RoomsOrm.GetRoomAvailability();
            labelRoomsDisponible.Text = $"{roomStats.Available}/{roomStats.Occupied}";

            // Get total number of sold tickets
            labelSoldTickets.Text = TicketsOrm.GetTotalSoldTickets().ToString();
        }

        /// <summary>
        /// Loads and displays the next 5 upcoming events in the data grid.
        /// </summary>
        private void LoadUpcomingEvents()
        {
            var upcomingEvents = EventsOrm.GetUpcomingEvents(5);
            dataGridViewEvents.DataSource = upcomingEvents;
            dataGridViewEvents.ReadOnly = true;
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optionally hide the ID column if present
            if (dataGridViewEvents.Columns.Contains("id"))
                dataGridViewEvents.Columns["id"].Visible = false;
        }
    }
}