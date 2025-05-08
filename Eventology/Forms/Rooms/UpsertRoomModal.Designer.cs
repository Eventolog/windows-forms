namespace Eventology.Forms.Rooms
{
    partial class UpsertRoomModal
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDistributionsWithSeats = new System.Windows.Forms.CheckBox();
            this.buttonEditDistribution = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(17, 59);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 13);
            this.labelDescription.TabIndex = 21;
            this.labelDescription.Text = "Descripció";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(17, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Nom";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(104, 59);
            this.textBoxDescription.MaxLength = 500;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(343, 79);
            this.textBoxDescription.TabIndex = 19;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(104, 18);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 20);
            this.textBoxName.TabIndex = 18;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.BackColor = System.Drawing.Color.Transparent;
            this.labelCapacity.ForeColor = System.Drawing.Color.White;
            this.labelCapacity.Location = new System.Drawing.Point(17, 172);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(52, 13);
            this.labelCapacity.TabIndex = 23;
            this.labelCapacity.Text = "Capacitat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Distribucio amb seients";
            // 
            // checkBoxDistributionsWithSeats
            // 
            this.checkBoxDistributionsWithSeats.AutoSize = true;
            this.checkBoxDistributionsWithSeats.Checked = true;
            this.checkBoxDistributionsWithSeats.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDistributionsWithSeats.Location = new System.Drawing.Point(139, 230);
            this.checkBoxDistributionsWithSeats.Name = "checkBoxDistributionsWithSeats";
            this.checkBoxDistributionsWithSeats.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDistributionsWithSeats.TabIndex = 25;
            this.checkBoxDistributionsWithSeats.UseVisualStyleBackColor = true;
            this.checkBoxDistributionsWithSeats.CheckedChanged += new System.EventHandler(this.checkBoxDistributionsWithSeats_CheckedChanged);
            // 
            // buttonEditDistribution
            // 
            this.buttonEditDistribution.Location = new System.Drawing.Point(171, 226);
            this.buttonEditDistribution.Name = "buttonEditDistribution";
            this.buttonEditDistribution.Size = new System.Drawing.Size(107, 23);
            this.buttonEditDistribution.TabIndex = 26;
            this.buttonEditDistribution.Text = "Editar distribucio";
            this.buttonEditDistribution.UseVisualStyleBackColor = true;
            this.buttonEditDistribution.Click += new System.EventHandler(this.buttonEditDistribution_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(275, 336);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(368, 336);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(104, 172);
            this.numericUpDownCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCapacity.TabIndex = 29;
            this.numericUpDownCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UpsertRoomModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eventology.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(465, 376);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEditDistribution);
            this.Controls.Add(this.checkBoxDistributionsWithSeats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Name = "UpsertRoomModal";
            this.Text = "UpsertRoomModal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDistributionsWithSeats;
        private System.Windows.Forms.Button buttonEditDistribution;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
    }
}