﻿using System;
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

            // Validar les credencials
            if (username == "admin" && password == "admin")
            {
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Credencials incorrectes. Torna-ho a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}