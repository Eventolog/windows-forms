using System.Windows.Forms;
using Eventology.Forms;

namespace Eventology
{
    public partial class EventologyForm : Form
    {
        public EventologyForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            ShowLoginForm();
        }

        private void buttonInit_Click(object sender, System.EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;

            homeForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void buttonEvents_Click(object sender, System.EventArgs e)
        {
            EventsForm eventForm = new EventsForm();
            eventForm.TopLevel = false;
            eventForm.FormBorderStyle = FormBorderStyle.None;

            eventForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(eventForm);
            eventForm.Show();
        }

        private void buttonRooms_Click(object sender, System.EventArgs e)
        {
            RoomsForm roomForm = new RoomsForm();
            roomForm.TopLevel = false;
            roomForm.FormBorderStyle = FormBorderStyle.None;

            roomForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(roomForm);
            roomForm.Show();
        }

        private void buttonUsers_Click(object sender, System.EventArgs e)
        {
            UsersForm userForm = new UsersForm();
            userForm.TopLevel = false;
            userForm.FormBorderStyle = FormBorderStyle.None;

            userForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(userForm);
            userForm.Show();
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Estàs segur que vols sortir?", "Sortir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;

            loginForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();

            mainPanel.Controls.Add(loginForm);
            loginForm.Show();
        }
    }
}