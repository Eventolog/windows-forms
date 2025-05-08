using System;
using Eventology.Utils;
using System.Windows.Forms;
using Eventology.Models.Management;

/// <summary>
/// Login form for the Eventology system.
/// Allows users to authenticate with username and password,
/// checks their role, and triggers the login success event.
/// </summary>
namespace Eventology.Forms
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Event triggered when the user logs in successfully.
        /// </summary>
        public event EventHandler LoginSuccessful;

        /// <summary>
        /// Initializes the LoginForm and sets up key listeners.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

            // Add Enter key listener on username and password fields
            this.textBoxUser.KeyDown += TextBoxUser_KeyDown;
            this.textBoxPassword.KeyDown += TextBoxPassword_KeyDown;

            // Set the default button to trigger on Enter key
            this.AcceptButton = this.buttonLogin;
        }

        /// <summary>
        /// Validates the login credentials and sets the active user if successful.
        /// Only allows access to users with roles "organizer" or "superadmin".
        /// </summary>
        private void ValidateLogin()
        {
            string username = textBoxUser.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            var user = UsersOrm.GetUserByCredentials(username, password);

            if (user != null)
            {
                // Only allow users with valid roles
                if (user.type != "organizer" && user.type != "superadmin")
                {
                    MessageBox.Show("No tens permisos per accedir.", "Accés denegat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Set current session user
                CurrentSession.LoggedUser = user;

                Console.WriteLine($"Usuari iniciat: {user.name}, Rol: {user.type}");

                // Trigger the success event
                LoginSuccessful?.Invoke(this, EventArgs.Empty);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Credencials incorrectes. Torna-ho a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles Enter key press on the username textbox.
        /// </summary>
        private void TextBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateLogin();
            }
        }

        /// <summary>
        /// Handles Enter key press on the password textbox.
        /// </summary>
        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateLogin();
            }
        }

        /// <summary>
        /// Handles the login button click.
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }
    }
}