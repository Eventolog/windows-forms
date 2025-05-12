namespace Eventology.Forms.Rooms
{
    partial class RoomsForm
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
            this.labelRooms = new System.Windows.Forms.Label();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.BackColor = System.Drawing.Color.Transparent;
            this.labelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRooms.ForeColor = System.Drawing.Color.White;
            this.labelRooms.Location = new System.Drawing.Point(37, 58);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(54, 20);
            this.labelRooms.TabIndex = 5;
            this.labelRooms.Text = "Sales";
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AllowUserToResizeColumns = false;
            this.dataGridViewRooms.AllowUserToResizeRows = false;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(65, 96);
            this.dataGridViewRooms.MultiSelect = false;
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(542, 341);
            this.dataGridViewRooms.TabIndex = 6;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(613, 96);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 7;
            this.btnAddRoom.Text = "Afegir";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(613, 125);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(75, 23);
            this.btnEditRoom.TabIndex = 8;
            this.btnEditRoom.Text = "Editar";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(613, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eventology.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(854, 505);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.labelRooms);
            this.Name = "RoomsForm";
            this.Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnDelete;
    }
}