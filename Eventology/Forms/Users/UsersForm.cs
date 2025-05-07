using System;
using System.Windows.Forms;
using Eventology.Models;
using Eventology.Models.Management;

namespace Eventology.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            LoadOrganizers();
        }

        private void LoadOrganizers()
        {
            var organizers = UsersOrm.SelectOrganizers();
            dataGridViewOrganizers.DataSource = organizers;
            if (dataGridViewOrganizers.Columns.Contains("id"))
                dataGridViewOrganizers.Columns["id"].Visible = false;
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

        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
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
    }
}