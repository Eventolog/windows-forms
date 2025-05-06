using System.Linq;
using System.Windows.Forms;
using Eventology.Models.Management;

namespace Eventology.Forms
{
    public partial class EventDetailsModal : Form
    {
        private int _eventId;

        public EventDetailsModal(int eventId)
        {
            InitializeComponent();

            _eventId = eventId;
            LoadEventDetails();
        }

        private void LoadEventDetails()
        {
            var ev = Orm.db.events.FirstOrDefault(e => e.id == _eventId);
            if (ev != null)
            {
                textBoxName.Text = ev.name;
                textBoxDescription.Text = ev.description;
                textBoxStartTime.Text = ev.start_time.ToString("g");
                textBoxEndTime.Text = ev.end_time.ToString("g");
                textBoxStatus.Text = ev.status;
                textBoxRoom.Text = ev.rooms?.name ?? "No assignada";
                textBoxOrganizer.Text = ev.users?.name ?? "Desconegut";
            }
            else
            {
                MessageBox.Show("No s'ha trobat l'esdeveniment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}