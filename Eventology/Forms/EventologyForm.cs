using System.Drawing;
using System.Windows.Forms;
using Eventology.Forms;

namespace Eventology
{
    public partial class EventologyForm : Form
    {
        private Button selectedButton = null;

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

        private void button_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Dibuixar la línia sota del botó seleccionat o quan el ratolí passi per sobre
                if (button == selectedButton || button.ClientRectangle.Contains(button.PointToClient(MousePosition)))
                {
                    using (Pen pen = new Pen(Color.Red, 2))  // Canvia el color i grosor si vols
                    {
                        e.Graphics.DrawLine(pen, 0, button.Height - 1, button.Width, button.Height - 1);
                    }
                }
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

                    button.Paint += button_Paint;

                    button.MouseEnter += (s, e) =>
                    {
                        button.Invalidate();  // Dibuixar la línia sota del botó quan el ratolí entra
                    };

                    button.MouseLeave += (s, e) =>
                    {
                        button.Invalidate();  // Dibuixar la línia sota del botó quan el ratolí surt
                    };

                    // Afegir esdeveniment de clic per establir la línia sota
                    button.Click += (s, e) =>
                    {
                        SetSelectedButton(button);
                    };
                }
            }
        }

        private void SetSelectedButton(Button button)
        {
            // Eliminar línia sota de l'anterior botó seleccionat
            if (selectedButton != null)
            {
                selectedButton.Invalidate();
            }

            selectedButton = button;

            button.Invalidate();
        }
    }
}