using System;
using System.Windows.Forms;
using Eventology.Models.Management;

namespace Eventology.Forms
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();

            LoadEvents();

            dataGridViewEvents.SelectionChanged += dataGridViewEvents_SelectionChanged;
        }

        private void LoadEvents()
        {
            var events = EventsOrm.SelectAllEvents();
            dataGridViewEvents.DataSource = events;
            if (dataGridViewEvents.Columns.Contains("id"))
                dataGridViewEvents.Columns["id"].Visible = false;
        }

        private void dataGridViewEvents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dataGridViewEvents.SelectedRows[0].Cells["id"].Value);
                var users = UsersOrm.SelectUsersByEvent(eventId);
                dataGridViewUsers.DataSource = users;
                if (dataGridViewUsers.Columns.Contains("id"))
                    dataGridViewUsers.Columns["id"].Visible = false;
            }
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeeEvent_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeeUser_Click(object sender, EventArgs e)
        {

        }
    }
}