using System;
using System.Drawing;
using System.Windows.Forms;
using Eventology.Forms;
using Eventology.Forms.Rooms;

namespace Eventology
{
    public partial class EventologyForm : Form
    {
        private Button selectedButton = null;

        public EventologyForm()
        {
            InitializeComponent();

            CustomizeWindow();
            CustomizeButtons();

            ToggleButtons(false);
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
            SwitchForm(new RoomDistributionEditorForm());
        }

        private void buttonUsers_Click(object sender, System.EventArgs e)
        {
            SwitchForm(new UsersForm());
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            SetSelectedButton(null);
            this.ActiveControl = null;

            if (MessageBox.Show("Estàs segur que vols tancar la sessió?", "Sortir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SetSelectedButton(null);
                this.ActiveControl = null;

                // Deshabilitar botons abans de mostrar el formulari de login
                ToggleButtons(false);
                ShowLoginForm();
            }
        }

        private void button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            // Eliminar rectangle de focus visual
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

        private void EventologyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Estàs segur que vols sortir?", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

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

        private void CustomizeWindow()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += EventologyForm_FormClosing;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

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

        private void OnLoginSuccessful(object sender, EventArgs e)
        {
            ToggleButtons(true);
            SwitchForm(new HomeForm());

            this.ActiveControl = null;
        }
    }
}