using Eventology.Models.Management;
using System;
using System.Windows.Forms;

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

        private void ValidateLogin()
        {
            string username = textBoxUser.Text;
            string password = textBoxPassword.Text;

            bool isValid = UsersOrm.ValidateUserLogin(username, password);

            if (isValid)
            {
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Credencials incorrectes. Torna-ho a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// (Only enable for development environment) Login with root/root credentials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = "root";
            textBoxPassword.Text = "root";
            this.ValidateLogin();
        }
    }
}