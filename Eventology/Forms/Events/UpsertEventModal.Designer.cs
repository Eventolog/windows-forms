namespace Eventology.Forms
{
    partial class UpsertEventModal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpsertEventModal));
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelOrganizer = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelInit = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxOrganizer = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.ForeColor = System.Drawing.Color.White;
            this.labelRoom.Location = new System.Drawing.Point(13, 166);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(32, 13);
            this.labelRoom.TabIndex = 18;
            this.labelRoom.Text = "Sala";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(13, 64);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 13);
            this.labelDescription.TabIndex = 17;
            this.labelDescription.Text = "Descripció";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(13, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Nom";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(100, 64);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(343, 79);
            this.textBoxDescription.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // labelOrganizer
            // 
            this.labelOrganizer.AutoSize = true;
            this.labelOrganizer.BackColor = System.Drawing.Color.Transparent;
            this.labelOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrganizer.ForeColor = System.Drawing.Color.White;
            this.labelOrganizer.Location = new System.Drawing.Point(13, 330);
            this.labelOrganizer.Name = "labelOrganizer";
            this.labelOrganizer.Size = new System.Drawing.Size(79, 13);
            this.labelOrganizer.TabIndex = 26;
            this.labelOrganizer.Text = "Organitzador";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.White;
            this.labelState.Location = new System.Drawing.Point(13, 287);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(36, 13);
            this.labelState.TabIndex = 25;
            this.labelState.Text = "Estat";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.BackColor = System.Drawing.Color.Transparent;
            this.labelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.ForeColor = System.Drawing.Color.White;
            this.labelEnd.Location = new System.Drawing.Point(13, 249);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(34, 13);
            this.labelEnd.TabIndex = 24;
            this.labelEnd.Text = "Final";
            // 
            // labelInit
            // 
            this.labelInit.AutoSize = true;
            this.labelInit.BackColor = System.Drawing.Color.Transparent;
            this.labelInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInit.ForeColor = System.Drawing.Color.White;
            this.labelInit.Location = new System.Drawing.Point(13, 209);
            this.labelInit.Name = "labelInit";
            this.labelInit.Size = new System.Drawing.Size(31, 13);
            this.labelInit.TabIndex = 23;
            this.labelInit.Text = "Inici";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(368, 373);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(275, 373);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CustomFormat = "MMMMdd, yyyy | HH:mm";
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(100, 203);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartTime.TabIndex = 29;
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CustomFormat = "MMMMdd, yyyy | HH:mm";
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(100, 243);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndTime.TabIndex = 30;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "scheduled",
            "cancelled",
            "completed"});
            this.comboBoxStatus.Location = new System.Drawing.Point(100, 284);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 32;
            // 
            // comboBoxOrganizer
            // 
            this.comboBoxOrganizer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "type", true));
            this.comboBoxOrganizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrganizer.FormattingEnabled = true;
            this.comboBoxOrganizer.Location = new System.Drawing.Point(100, 327);
            this.comboBoxOrganizer.Name = "comboBoxOrganizer";
            this.comboBoxOrganizer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrganizer.TabIndex = 33;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Eventology.Models.users);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "scheduled",
            "cancelled",
            "completed"});
            this.comboBoxRoom.Location = new System.Drawing.Point(100, 161);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(185, 21);
            this.comboBoxRoom.TabIndex = 34;
            // 
            // UpsertEventModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eventology.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(465, 420);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.comboBoxOrganizer);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelOrganizer);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelInit);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpsertEventModal";
            this.Text = "Gestionar Event";
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelOrganizer;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelInit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxOrganizer;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.ComboBox comboBoxRoom;
    }
}