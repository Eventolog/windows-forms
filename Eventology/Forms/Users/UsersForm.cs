using System;
using System.Windows.Forms;
using Eventology.Models;
using Eventology.Models.Management;

namespace Eventology.Forms
{
    public partial class UsersForm : Form
    {
        private int? selectedUserId = null;

        public UsersForm()
        {
            InitializeComponent();

            LoadOrganizers();

            // No he trobat cap manera de fer-ho funcionar
            ClearFields();
            buttonClean.PerformClick();
        }

        private void LoadOrganizers()
        {
            var organizers = UsersOrm.SelectOrganizers();
            dataGridViewOrganizers.DataSource = organizers;
            if (dataGridViewOrganizers.Columns.Contains("id"))
                dataGridViewOrganizers.Columns["id"].Visible = false;
            dataGridViewOrganizers.Rows[0].Selected = false;
        }

        private void buttonAddOrganizer_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tots els camps són obligatoris.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedUserId.HasValue)
            {
                // Update  
                var updated = UsersOrm.UpdateUser(selectedUserId.Value, name, email, password);
                if (updated)
                {
                    MessageBox.Show("Organitzador actualitzat correctament.", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrganizers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error en actualitzar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Insert  
                var newOrganizer = new users
                {
                    name = name,
                    email = email,
                    password = password,
                    type = "organizer"
                };

                if (UsersOrm.InsertUser(newOrganizer))
                {
                    MessageBox.Show("Organitzador creat correctament.", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrganizers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No s'ha pogut crear l'organitzador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewOrganizers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrganizers.SelectedRows.Count > 0)
            {
                var row = dataGridViewOrganizers.SelectedRows[0];
                selectedUserId = Convert.ToInt32(row.Cells["id"].Value);
                textBoxName.Text = row.Cells["name"].Value.ToString();
                textBoxEmail.Text = row.Cells["email"].Value.ToString();
                textBoxPassword.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void buttonDeleteOrganizer_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrganizers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un organitzador per eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(dataGridViewOrganizers.SelectedRows[0].Cells["id"].Value);

            var confirm = MessageBox.Show("Segur que vols eliminar aquest organitzador?", "Confirmació", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (UsersOrm.DeleteUserById(userId))
                {
                    MessageBox.Show("Organitzador eliminat correctament.", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrganizers();
                }
                else
                {
                    MessageBox.Show("No s'ha pogut eliminar l'organitzador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            selectedUserId = null;
            dataGridViewOrganizers.ClearSelection();
        }
    }
}