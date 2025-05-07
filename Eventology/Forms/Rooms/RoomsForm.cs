using System.Windows.Forms;

namespace Eventology.Forms.Rooms
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, System.EventArgs e)
        {
            UpsertRoomModal modal = new UpsertRoomModal();
            if(modal.ShowDialog() == DialogResult.OK){
                LoadRooms();
            }
        }

        private void LoadRooms()
        {
            // TODO: A la room distribution modal afegir getExistingSeats
            // i al save UpsertRoomModal, si es una room amb seats validar hi ha
            // el mateix numero de seats que a capacity, ademes pasar capacity com
            // valor al constructor, i anar pasant distribucio entre upsertRoomModal i
            // roomDistribution
        }
    }
}
