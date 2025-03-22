using System.Drawing;
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

            CustomizeButtons();
            ShowLoginForm();
        }

        private void buttonInit_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new HomeForm());
        }

        private void buttonEvents_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new EventsForm());
        }

        private void buttonRooms_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new RoomsForm());
        }

        private void buttonUsers_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new UsersForm());
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

        private void SwitchForm(Form newForm)
        {
            mainPanel.SuspendLayout();

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(newForm);
            newForm.Show();

            mainPanel.ResumeLayout();
        }

        private void CustomizeButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = this.BackColor;
                    button.ForeColor = Color.Black;
                    button.Cursor = Cursors.Hand;
                }
            }
        }
    }
}