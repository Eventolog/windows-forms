using Eventology.Models.Management;
using System;
using System.Windows.Forms;

namespace Eventology.Forms.Rooms
{

    /// <summary>
    /// Modal used to create or updet a room and its selected distribution
    /// </summary>
    public partial class UpsertRoomModal : Form
    {
        /// <summary>
        /// JSON representation of the current room layout
        /// </summary>
        String distributionJson = "";

        /// <summary>
        /// The room object to be updated
        /// </summary>
        Models.rooms updatingRoom = null;

        /// <summary>
        /// Indicates if an object is being updated or not
        /// </summary>
        bool updating = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRoomModal"/> class for creating a new room.
        /// </summary>
        public UpsertRoomModal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRoomModal"/> class for 
        /// updating an existing room and fill modal inputs with the room data.
        /// </summary>
        /// <param name="room">The room object to be updated.</param>
        public UpsertRoomModal(Models.rooms room)
        {
            InitializeComponent();
            this.updatingRoom = room;
            this.updating = true;

            // fill modal inputs
            textBoxName.Text = room.name;
            textBoxDescription.Text = room.description;
            numericUpDownCapacity.Value = (int) room.capacity;
            checkBoxDistributionsWithSeats.Checked = room.hasSeatingDistribution;
            this.distributionJson = room.roomLayout;
        }

        /// <summary>
        /// Handles the CheckedChanged event of the checkBoxDistributionsWithSeats control
        /// Toggles the visibility of the 'Edit Distribution' button based on whether the room 
        /// is configured with seats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxDistributionsWithSeats_CheckedChanged(object sender, EventArgs e)
        {
            buttonEditDistribution.Visible = checkBoxDistributionsWithSeats.Checked;
        }

        /// <summary>
        /// Handles onClick event and validate data and insert or update a room into the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string description = textBoxDescription.Text.Trim();
            int capacity = (int)numericUpDownCapacity.Value;
            bool hasSeatingDistribution = checkBoxDistributionsWithSeats.Checked;
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description)
                || capacity <= 0)
            {
                MessageBox.Show("Tots els camps són obligatoris.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (updating)
            {
                updatingRoom.name = name;
                updatingRoom.description = description;
                updatingRoom.capacity = capacity;
                updatingRoom.hasSeatingDistribution = hasSeatingDistribution;
                updatingRoom.roomLayout = this.distributionJson;

                if (RoomsOrm.UpdateRoom(updatingRoom))
                {
                    MessageBox.Show("Sala actualitzada correctament.", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurregut un error inesperat actualitzant la sala.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                var room = new Models.rooms
                {
                    name = name,
                    description = description,
                    capacity = capacity,
                    hasSeatingDistribution = hasSeatingDistribution,
                    roomLayout = this.distributionJson
                };
                if (RoomsOrm.InsertRoom(room))
                {
                    MessageBox.Show("Sala afegida correctament.", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurregut un error inesperat afegint la sala.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
                
            
        }

        /// <summary>
        /// Handles onClick event, cancel the insert/edit and close the modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens a modal to edit the room distribution of the room being created/edited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditDistribution_Click(object sender, EventArgs e)
        {
            int capacity = (int)numericUpDownCapacity.Value;
            string roomName = textBoxName.Text;
            if (string.IsNullOrEmpty(roomName))
            {
                roomName = "Sala sense nom";
            }
            RoomDistributionEditorModal modal;
            if (updating)
            {
                modal = new RoomDistributionEditorModal(this.updatingRoom.roomLayout, capacity, roomName);
            }
            else
            {
                modal = new RoomDistributionEditorModal(capacity, roomName);
            }
            if (modal.ShowDialog() == DialogResult.OK)
            {
                this.distributionJson = modal.getGeneratedJson();
            }
        }
    }
}
