namespace Eventology.Forms
{
    partial class EventsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AllowUserToAddRows = false;
            this.dataGridViewEvents.AllowUserToDeleteRows = false;
            this.dataGridViewEvents.AllowUserToResizeColumns = false;
            this.dataGridViewEvents.AllowUserToResizeRows = false;
            this.dataGridViewEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(83, 94);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(473, 341);
            this.dataGridViewEvents.TabIndex = 2;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(639, 94);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(383, 290);
            this.dataGridViewUsers.TabIndex = 3;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.BackColor = System.Drawing.Color.Transparent;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.ForeColor = System.Drawing.Color.White;
            this.labelEvents.Location = new System.Drawing.Point(55, 64);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(64, 20);
            this.labelEvents.TabIndex = 4;
            this.labelEvents.Text = "Events";
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.White;
            this.labelUsers.Location = new System.Drawing.Point(604, 64);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(56, 20);
            this.labelUsers.TabIndex = 5;
            this.labelUsers.Text = "Users";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(656, 412);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Afegir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(799, 412);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSee
            // 
            this.buttonSee.Location = new System.Drawing.Point(942, 412);
            this.buttonSee.Name = "buttonSee";
            this.buttonSee.Size = new System.Drawing.Size(75, 23);
            this.buttonSee.TabIndex = 8;
            this.buttonSee.Text = "Més info";
            this.buttonSee.UseVisualStyleBackColor = true;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eventology.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1065, 505);
            this.Controls.Add(this.buttonSee);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.dataGridViewEvents);
            this.MinimumSize = new System.Drawing.Size(16, 100);
            this.Name = "EventsForm";
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSee;
    }
}