using System;
using System.Windows.Forms;
using Eventology.Models.Management;

namespace Eventology.Forms
{
    public partial class AddUserModal : Form
    {
        private int eventId;

        public AddUserModal(int eventId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.eventId = eventId;

            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = UsersOrm.SelectAvailableUsersForEvent(eventId);

            if (users.Count == 0)
            {
                MessageBox.Show("Tots els usuaris ja estan assignats a aquest esdeveniment.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            comboBoxUser.DataSource = users;
            comboBoxUser.DisplayMember = "name";
            comboBoxUser.ValueMember = "id";
            comboBoxUser.SelectedIndex = -1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un usuari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = (int)comboBoxUser.SelectedValue;

            if (UsersOrm.AddUserToEvent(userId, eventId))
            {
                MessageBox.Show("Usuari afegit a l’esdeveniment.", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No s'ha pogut afegir l'usuari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}