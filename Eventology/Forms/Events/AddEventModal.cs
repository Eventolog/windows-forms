using Eventology.Models.Management;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Eventology.Forms
{
    public partial class AddEventModal : Form
    {
        public AddEventModal()
        {
            InitializeComponent();

            LoadOrganizers();
            LoadRooms();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadOrganizers()
        {
            var organizers = UsersOrm.SelectOrganizers();
            comboBoxOrganizer.DataSource = organizers;
            comboBoxOrganizer.DisplayMember = "name";
            comboBoxOrganizer.ValueMember = "id";
            comboBoxOrganizer.SelectedIndex = -1;
        }

        private void LoadRooms()
        {
            var rooms = RoomsOrm.SelectAllRooms();
            comboBoxRoom.DataSource = rooms;
            comboBoxRoom.DisplayMember = "name";
            comboBoxRoom.ValueMember = "id";
            comboBoxRoom.SelectedIndex = -1;
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            DateTime start = dateTimePickerStartTime.Value;
            DateTime end = dateTimePickerEndTime.Value;
            string status = comboBoxStatus.Text;
            object organizer = comboBoxOrganizer.SelectedValue;
            object room = comboBoxRoom.SelectedValue;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(status) || organizer == null || room == null)
            {
                MessageBox.Show("Tots els camps són obligatoris.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (end <= start)
            {
                MessageBox.Show("La data de finalització ha de ser posterior a la d'inici.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newEvent = new Models.events
            {
                name = name,
                description = description,
                start_time = start,
                end_time = end,
                status = status,
                organizer_id = (int)organizer,
                room_id = (int)room,
                created_at = DateTime.Now,
                if_full_day = false
            };

            if (EventsOrm.InsertEvent(newEvent))
            {
                MessageBox.Show("Esdeveniment afegit correctament.", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}