using System;
using Eventology.Utils;
using System.Windows.Forms;
using Eventology.Models.Management;

namespace Eventology.Forms
{
    public partial class LoginForm : Form
    {
        public event EventHandler LoginSuccessful;

        public LoginForm()
        {
            InitializeComponent();

            this.textBoxUser.KeyDown += TextBoxUser_KeyDown;
            this.textBoxPassword.KeyDown += TextBoxPassword_KeyDown;
            this.AcceptButton = this.buttonLogin;

        }

        private void ValidateLogin()
        {
            string username = textBoxUser.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            var user = UsersOrm.GetUserByCredentials(username, password);

            if (user != null)
            {
                if (user.type != "organizer" && user.type != "superadmin")
                {
                    MessageBox.Show("No tens permisos per accedir.", "Accés denegat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CurrentSession.LoggedUser = user;

                Console.WriteLine($"Usuari iniciat: {user.name}, Rol: {user.type}");

                LoginSuccessful?.Invoke(this, EventArgs.Empty);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Credencials incorrectes. Torna-ho a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateLogin();
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateLogin();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }
    }
}