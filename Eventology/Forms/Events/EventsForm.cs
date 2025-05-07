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
            var modal = new AddEventModal();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                LoadEvents();
            }
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dataGridViewEvents.SelectedRows[0].Cells["id"].Value);
                var confirm = MessageBox.Show("Segur que vols eliminar aquest esdeveniment?", "Confirmació", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    EventsOrm.DeleteEventById(eventId);
                    LoadEvents();
                }
            }
        }

        private void buttonSeeEvent_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un esdeveniment per veure'n els detalls.", "Cap selecció", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int eventId = Convert.ToInt32(dataGridViewEvents.SelectedRows[0].Cells["id"].Value);

            var modal = new EventDetailsModal(eventId);
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowDialog();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            int eventId = Convert.ToInt32(dataGridViewEvents.SelectedRows[0].Cells["id"].Value);

            // Abans de crear el modal, comprova si hi ha usuaris disponibles
            var availableUsers = UsersOrm.SelectAvailableUsersForEvent(eventId);
            if (availableUsers.Count == 0)
            {
                MessageBox.Show("Tots els usuaris ja estan assignats a aquest esdeveniment.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var modal = new AddUserModal(eventId);
            if (modal.ShowDialog() == DialogResult.OK)
            {
                var users = UsersOrm.SelectUsersByEvent(eventId);
                dataGridViewUsers.DataSource = users;
                if (dataGridViewUsers.Columns.Contains("id"))
                    dataGridViewUsers.Columns["id"].Visible = false;
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count > 0 && dataGridViewUsers.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dataGridViewEvents.SelectedRows[0].Cells["id"].Value);
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["id"].Value);

                var confirm = MessageBox.Show("Segur que vols eliminar aquest usuari de l’esdeveniment?", "Confirmació", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    UsersOrm.DeleteUserFromEvent(userId, eventId);

                    var users = UsersOrm.SelectUsersByEvent(eventId);
                    dataGridViewUsers.DataSource = users;
                    if (dataGridViewUsers.Columns.Contains("id"))
                        dataGridViewUsers.Columns["id"].Visible = false;
                }
            }
        }
    }
}