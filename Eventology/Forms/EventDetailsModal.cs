using System.Windows.Forms;

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
            
        }
    }
}