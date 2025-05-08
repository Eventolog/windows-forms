using System;
using System.Drawing;
using System.Windows.Forms;
using Eventology.Forms;
using Eventology.Utils;

/// <summary>
/// Main application form for Eventology.
/// This dashboard controls navigation between different modules:
/// Home, Events, Rooms, Users, and handles login/logout flows.
/// It adjusts available features based on the user's role (organizer or superadmin).
/// </summary>
namespace Eventology
{
    public partial class EventologyForm : Form
    {
        /// <summary>
        /// Tracks which navigation button is currently selected.
        /// </summary>
        private Button selectedButton = null;

        /// <summary>
        /// Initializes the Eventology main form, sets up the UI, 
        /// disables buttons until login, and shows the login form.
        /// </summary>
        public EventologyForm()
        {
            InitializeComponent();

            CustomizeWindow();
            CustomizeButtons();

            ToggleButtons(false); // Disable all buttons at startup
            ShowLoginForm();
        }

        /// <summary>
        /// Applies button access permissions based on the logged-in user's role.
        /// Organizer → Home, Rooms, Exit; Superadmin → all buttons.
        /// </summary>
        private void ApplyRolePermissions()
        {
            var user = CurrentSession.LoggedUser;

            if (user == null)
            {
                MessageBox.Show("No hi ha cap usuari actiu. Tancant aplicació."); // Catalan: No active user. Closing application.
                this.Close();
                return;
            }

            if (user.type == "organizer")
            {
                // Enable only Home, Rooms, and Exit buttons
                buttonInit.Enabled = true;
                buttonRooms.Enabled = true;
                buttonExit.Enabled = true;

                buttonEvents.Enabled = false;
                buttonUsers.Enabled = false;
            }
            else if (user.type == "superadmin")
            {
                // Enable all buttons
                buttonInit.Enabled = true;
                buttonRooms.Enabled = true;
                buttonExit.Enabled = true;
                buttonEvents.Enabled = true;
                buttonUsers.Enabled = true;
            }
        }

        /// <summary>
        /// Opens the Home module.
        /// </summary>
        private void buttonInit_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new HomeForm());
        }

        /// <summary>
        /// Opens the Events module.
        /// </summary>
        private void buttonEvents_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new EventsForm());
        }

        /// <summary>
        /// Opens the Rooms module.
        /// </summary>
        private void buttonRooms_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new RoomsForm());
        }

        /// <summary>
        /// Opens the Users module.
        /// </summary>
        private void buttonUsers_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new UsersForm());
        }

        /// <summary>
        /// Handles the Exit button: confirms logout, disables buttons, and shows login form again.
        /// </summary>
        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            SetSelectedButton(null);
            this.ActiveControl = null;

            if (MessageBox.Show("Estàs segur que vols tancar la sessió?", "Sortir", MessageBoxButtons.YesNo) == DialogResult.Yes) // Catalan: Are you sure you want to log out?
            {
                SetSelectedButton(null);
                this.ActiveControl = null;

                ToggleButtons(false);
                ShowLoginForm();
            }
        }

        /// <summary>
        /// Customizes the visual paint of buttons, including focus and hover states.
        /// Draws a red underline on the selected or hovered button.
        /// </summary>
        private void button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            // Remove the visual focus rectangle
            e.Graphics.Clear(btn.BackColor);
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            if (btn == selectedButton || btn.ClientRectangle.Contains(btn.PointToClient(MousePosition)))
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawLine(pen, 0, btn.Height - 1, btn.Width, btn.Height - 1);
                }
            }
        }

        /// <summary>
        /// Handles confirmation when the user tries to close the entire application window.
        /// </summary>
        private void EventologyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Estàs segur que vols sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Catalan: Are you sure you want to exit?

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Loads and embeds the login form inside the main panel.
        /// </summary>
        private void ShowLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;
            loginForm.LoginSuccessful += OnLoginSuccessful;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(loginForm);
            loginForm.Show();
        }

        /// <summary>
        /// Switches the embedded panel to display the given child form.
        /// </summary>
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

        /// <summary>
        /// Customizes all buttons on the form for flat style, mouse-over effects, and event handlers.
        /// </summary>
        private void CustomizeButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.MouseOverBackColor = button.BackColor;
                    button.FlatAppearance.MouseDownBackColor = button.BackColor;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = this.BackColor;
                    button.ForeColor = Color.Black;
                    button.Cursor = Cursors.Hand;

                    button.Paint += button_Paint;

                    button.MouseEnter += (s, e) =>
                    {
                        button.Invalidate();
                    };

                    button.MouseLeave += (s, e) =>
                    {
                        button.Invalidate();
                    };

                    button.Click += (s, e) =>
                    {
                        SetSelectedButton(button);
                    };
                }
            }
        }

        /// <summary>
        /// Marks the specified button as selected, updating its visual state.
        /// </summary>
        private void SetSelectedButton(Button button)
        {
            if (selectedButton != null)
            {
                selectedButton.Invalidate();
            }

            selectedButton = button;

            if (selectedButton != null)
            {
                selectedButton.Invalidate();
            }
        }

        /// <summary>
        /// Configures the main window’s appearance and disables resizing.
        /// </summary>
        private void CustomizeWindow()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += EventologyForm_FormClosing;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Enables or disables all button controls on the form.
        /// </summary>
        private void ToggleButtons(bool enable)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = enable;
                }
            }
        }

        /// <summary>
        /// Event handler called when login succeeds. 
        /// Enables buttons, applies role permissions, and switches to the Home module.
        /// </summary>
        private void OnLoginSuccessful(object sender, EventArgs e)
        {
            ToggleButtons(true);
            ApplyRolePermissions();

            SwitchForm(new HomeForm());

            this.ActiveControl = null;
        }
    }
}