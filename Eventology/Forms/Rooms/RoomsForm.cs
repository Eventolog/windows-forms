using Eventology.Models.Management;
using System;
using System.Windows.Forms;

namespace Eventology.Forms.Rooms
{
    /// <summary>
    /// Form to manage room records: add, edit, and delete operations.
    /// </summary>
    public partial class RoomsForm : Form
    {

        /// <summary>
        /// Initializes the form and loads all rooms into the DataGridView.
        /// </summary>
        public RoomsForm()
        {
            InitializeComponent();
            LoadRooms();
        }

        /// <summary>
        /// Opens a modal to create a new room.
        /// Reloads the DataGridView if creation is successful.
        /// </summary>
        private void btnAddRoom_Click(object sender, System.EventArgs e)
        {
            UpsertRoomModal modal = new UpsertRoomModal();
            if(modal.ShowDialog() == DialogResult.OK){
                LoadRooms();
            }
        }


        /// <summary>
        /// Loads all room records into the DataGridView and configures the columns.
        /// </summary>
        private void LoadRooms()
        {
            var rooms = RoomsOrm.SelectAllRooms();
            dataGridViewRooms.DataSource = rooms;

            /// Rename cols names
            dataGridViewRooms.Columns["name"].HeaderText = "Nom";
            dataGridViewRooms.Columns["name"].Width = 150; // Set max width in pixels
            dataGridViewRooms.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dataGridViewRooms.Columns["capacity"].HeaderText = "Capacitat";
            dataGridViewRooms.Columns["capacity"].Width = 60;

            dataGridViewRooms.Columns["description"].HeaderText = "Descripcio";
            dataGridViewRooms.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewRooms.Columns["hasSeatingDistribution"].HeaderText = "Té distribució de seients";
            dataGridViewRooms.Columns["hasSeatingDistribution"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Hide specific navigation or unused columns
            dataGridViewRooms.Columns["id"].Visible = false;
            dataGridViewRooms.Columns["deleted"].Visible = false;
            dataGridViewRooms.Columns["roomLayout"].Visible = false;
            dataGridViewRooms.Columns["events"].Visible = false;
            dataGridViewRooms.Columns["seats"].Visible = false;
            dataGridViewRooms.Columns["inventory_rooms"].Visible = false;

            // TODO: A la room distribution modal afegir getExistingSeats
            // i al save UpsertRoomModal, si es una room amb seats validar hi ha
            // el mateix numero de seats que a capacity, ademes pasar capacity com
            // valor al constructor, i anar pasant distribucio entre upsertRoomModal i
            // roomDistribution
        }

        /// <summary>
        /// Opens a modal to edit the selected room.
        /// Updates the record in the database if the edit is confirmed.
        /// </summary>
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.CurrentRow?.DataBoundItem is Models.rooms selectedRoom)
            {
                UpsertRoomModal modal = new UpsertRoomModal(selectedRoom);
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    LoadRooms();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una sala per editar.", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Deletes the selected room from the database.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.CurrentRow?.DataBoundItem is Models.rooms selectedRoom)
            {
                var confirm = MessageBox.Show($"Segur que vols eliminar la sala '{selectedRoom.name}'?", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    bool deleted = RoomsOrm.DeleteRoom(selectedRoom);
                    if (deleted)
                    {
                        LoadRooms();
                    }
                    else
                    {
                        MessageBox.Show("Error eliminant la sala.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una sala per eliminar.", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
