using Eventology.Models.Management;
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
            comboBoxRoom.SelectedIndex = -1; // Opcional: no seleccions cap per defecte
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}