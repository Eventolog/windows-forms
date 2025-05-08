using System;
using System.Windows.Forms;
using Eventology.Models;
using Eventology.Models.Management;

/// <summary>
/// UsersForm manages organizers: create, update, delete, and display them in a grid.
/// </summary>
namespace Eventology.Forms
{
    public partial class UsersForm : Form
    {
        /// <summary>
        /// Tracks the currently selected organizer's ID (nullable).
        /// </summary>
        private int? selectedUserId = null;

        /// <summary>
        /// Initializes the form and loads organizers into the grid.
        /// </summary>
        public UsersForm()
        {
            InitializeComponent();

            LoadOrganizers();

            // Ensure textboxes are cleared on form load
            this.Shown += (s, e) => ClearFields();
        }

        /// <summary>
        /// Loads all organizers from the database and fills the DataGridView.
        /// </summary>
        private void LoadOrganizers()
        {
            var organizers = UsersOrm.SelectOrganizers();
            dataGridViewOrganizers.DataSource = organizers;

            if (dataGridViewOrganizers.Columns.Contains("id"))
                dataGridViewOrganizers.Columns["id"].Visible = false;

            if (dataGridViewOrganizers.Rows.Count > 0)
                dataGridViewOrganizers.ClearSelection(); // prevent pre-selection
        }

        /// <summary>
        /// Handles adding a new organizer or updating an existing one.
        /// </summary>
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
                // Update existing organizer
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
                // Insert new organizer
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

        /// <summary>
        /// Fills the textboxes when a row is selected in the DataGridView.
        /// </summary>
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

        /// <summary>
        /// Deletes the selected organizer from the database.
        /// </summary>
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
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No s'ha pogut eliminar l'organitzador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Clears all textboxes and resets the selected user.
        /// </summary>
        private void buttonClean_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Utility method to reset the form fields and clear selection.
        /// </summary>
        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            selectedUserId = null;

            if (dataGridViewOrganizers.Rows.Count > 0)
                dataGridViewOrganizers.ClearSelection();
        }
    }
}