using Eventology.Models.Management;
using System;
using System.Windows.Forms;

namespace Eventology.Forms.Rooms
{
    public partial class UpsertRoomModal : Form
    {
        /// <summary>
        /// JSON representation of the current room layout
        /// </summary>
        String distributionJson = "";

        Models.rooms updatingRoom = null;
        bool updating = false;
        public UpsertRoomModal()
        {
            genericContructor();
        }

        public UpsertRoomModal(Models.rooms room)
        {
            genericContructor();
            this.updatingRoom = room;
            this.updating = true;
        }

        private void genericContructor()
        {
            InitializeComponent();
            buttonEditDistribution.Visible = false;
        }

        private void checkBoxDistributionsWithSeats_CheckedChanged(object sender, EventArgs e)
        {
            buttonEditDistribution.Visible = checkBoxDistributionsWithSeats.Checked;
        }

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditDistribution_Click(object sender, EventArgs e)
        {
            var modal = new RoomDistributionEditorModal();
            if(modal.ShowDialog() == DialogResult.OK)
            {
                this.distributionJson = modal.getGeneratedJson();
            }
        }
    }
}
