namespace Eventology.Forms.Rooms
{
    partial class RoomDistributionEditorModal
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
            this.lblEventName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.qtySeat = new System.Windows.Forms.Label();
            this.lblSeatsAmount = new System.Windows.Forms.Label();
            this.numericPriceEditSeat = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteSeat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericPriceAddSeat = new System.Windows.Forms.NumericUpDown();
            this.roomPictureBox = new System.Windows.Forms.PictureBox();
            this.btnAddSeat = new System.Windows.Forms.Button();
            this.editSeatGroupbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAmountSeats = new System.Windows.Forms.GroupBox();
            this.btnSaveDistribution = new System.Windows.Forms.Button();
            this.lblRow = new System.Windows.Forms.Label();
            this.numericUpDownEditRow = new System.Windows.Forms.NumericUpDown();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.numericUpDownEditSeatNumber = new System.Windows.Forms.NumericUpDown();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.addSeatGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDownAddSeatNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownAddRow = new System.Windows.Forms.NumericUpDown();
            this.lblRowAddSeat = new System.Windows.Forms.Label();
            this.lblPriceAddSeat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceEditSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceAddSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).BeginInit();
            this.editSeatGroupbox.SuspendLayout();
            this.groupBoxAmountSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditSeatNumber)).BeginInit();
            this.addSeatGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSeatNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddRow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BackColor = System.Drawing.Color.Transparent;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(8, 40);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(382, 36);
            this.lblEventName.TabIndex = 30;
            this.lblEventName.Text = "Nom de la distribucio/sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Editor d\'escenari per la sala:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(426, 416);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 33);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.editSeat_Click);
            // 
            // qtySeat
            // 
            this.qtySeat.AutoSize = true;
            this.qtySeat.BackColor = System.Drawing.Color.Transparent;
            this.qtySeat.ForeColor = System.Drawing.Color.White;
            this.qtySeat.Location = new System.Drawing.Point(104, 26);
            this.qtySeat.Name = "qtySeat";
            this.qtySeat.Size = new System.Drawing.Size(13, 13);
            this.qtySeat.TabIndex = 27;
            this.qtySeat.Text = "0";
            // 
            // lblSeatsAmount
            // 
            this.lblSeatsAmount.AutoSize = true;
            this.lblSeatsAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblSeatsAmount.ForeColor = System.Drawing.Color.White;
            this.lblSeatsAmount.Location = new System.Drawing.Point(6, 25);
            this.lblSeatsAmount.Name = "lblSeatsAmount";
            this.lblSeatsAmount.Size = new System.Drawing.Size(100, 13);
            this.lblSeatsAmount.TabIndex = 26;
            this.lblSeatsAmount.Text = "Quantitat butaques:";
            // 
            // numericPriceEditSeat
            // 
            this.numericPriceEditSeat.Location = new System.Drawing.Point(425, 238);
            this.numericPriceEditSeat.Name = "numericPriceEditSeat";
            this.numericPriceEditSeat.Size = new System.Drawing.Size(121, 20);
            this.numericPriceEditSeat.TabIndex = 25;
            // 
            // btnDeleteSeat
            // 
            this.btnDeleteSeat.BackColor = System.Drawing.Color.White;
            this.btnDeleteSeat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteSeat.Location = new System.Drawing.Point(8, 194);
            this.btnDeleteSeat.Name = "btnDeleteSeat";
            this.btnDeleteSeat.Size = new System.Drawing.Size(124, 33);
            this.btnDeleteSeat.TabIndex = 28;
            this.btnDeleteSeat.Text = "Eliminar";
            this.btnDeleteSeat.UseVisualStyleBackColor = false;
            this.btnDeleteSeat.Click += new System.EventHandler(this.deleteSeat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 156);
            this.textBox1.TabIndex = 23;
            // 
            // numericPriceAddSeat
            // 
            this.numericPriceAddSeat.Location = new System.Drawing.Point(6, 55);
            this.numericPriceAddSeat.Name = "numericPriceAddSeat";
            this.numericPriceAddSeat.Size = new System.Drawing.Size(120, 20);
            this.numericPriceAddSeat.TabIndex = 22;
            // 
            // roomPictureBox
            // 
            this.roomPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roomPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPictureBox.Location = new System.Drawing.Point(12, 183);
            this.roomPictureBox.Name = "roomPictureBox";
            this.roomPictureBox.Size = new System.Drawing.Size(400, 279);
            this.roomPictureBox.TabIndex = 20;
            this.roomPictureBox.TabStop = false;
            // 
            // btnAddSeat
            // 
            this.btnAddSeat.BackColor = System.Drawing.Color.White;
            this.btnAddSeat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSeat.Location = new System.Drawing.Point(7, 232);
            this.btnAddSeat.Name = "btnAddSeat";
            this.btnAddSeat.Size = new System.Drawing.Size(124, 33);
            this.btnAddSeat.TabIndex = 19;
            this.btnAddSeat.Text = "Afegir";
            this.btnAddSeat.UseVisualStyleBackColor = false;
            this.btnAddSeat.Click += new System.EventHandler(this.addSeat_Click);
            // 
            // editSeatGroupbox
            // 
            this.editSeatGroupbox.BackColor = System.Drawing.Color.Transparent;
            this.editSeatGroupbox.Controls.Add(this.btnDeleteSeat);
            this.editSeatGroupbox.Controls.Add(this.numericUpDownEditSeatNumber);
            this.editSeatGroupbox.Controls.Add(this.lblSeatNumber);
            this.editSeatGroupbox.Controls.Add(this.numericUpDownEditRow);
            this.editSeatGroupbox.Controls.Add(this.lblRow);
            this.editSeatGroupbox.Controls.Add(this.label2);
            this.editSeatGroupbox.ForeColor = System.Drawing.Color.White;
            this.editSeatGroupbox.Location = new System.Drawing.Point(418, 183);
            this.editSeatGroupbox.Name = "editSeatGroupbox";
            this.editSeatGroupbox.Size = new System.Drawing.Size(140, 279);
            this.editSeatGroupbox.TabIndex = 31;
            this.editSeatGroupbox.TabStop = false;
            this.editSeatGroupbox.Text = "Editar butaca seleccionada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preu";
            // 
            // groupBoxAmountSeats
            // 
            this.groupBoxAmountSeats.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAmountSeats.Controls.Add(this.lblSeatsAmount);
            this.groupBoxAmountSeats.Controls.Add(this.qtySeat);
            this.groupBoxAmountSeats.Location = new System.Drawing.Point(149, 110);
            this.groupBoxAmountSeats.Name = "groupBoxAmountSeats";
            this.groupBoxAmountSeats.Size = new System.Drawing.Size(263, 58);
            this.groupBoxAmountSeats.TabIndex = 32;
            this.groupBoxAmountSeats.TabStop = false;
            this.groupBoxAmountSeats.UseCompatibleTextRendering = true;
            // 
            // btnSaveDistribution
            // 
            this.btnSaveDistribution.BackColor = System.Drawing.Color.White;
            this.btnSaveDistribution.Location = new System.Drawing.Point(14, 115);
            this.btnSaveDistribution.Name = "btnSaveDistribution";
            this.btnSaveDistribution.Size = new System.Drawing.Size(129, 53);
            this.btnSaveDistribution.TabIndex = 34;
            this.btnSaveDistribution.Text = "Guardar Distribucio";
            this.btnSaveDistribution.UseVisualStyleBackColor = false;
            this.btnSaveDistribution.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.BackColor = System.Drawing.Color.Transparent;
            this.lblRow.ForeColor = System.Drawing.Color.White;
            this.lblRow.Location = new System.Drawing.Point(6, 87);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(23, 13);
            this.lblRow.TabIndex = 10;
            this.lblRow.Text = "Fila";
            // 
            // numericUpDownEditRow
            // 
            this.numericUpDownEditRow.Location = new System.Drawing.Point(8, 103);
            this.numericUpDownEditRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEditRow.Name = "numericUpDownEditRow";
            this.numericUpDownEditRow.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEditRow.TabIndex = 11;
            this.numericUpDownEditRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblSeatNumber.ForeColor = System.Drawing.Color.White;
            this.lblSeatNumber.Location = new System.Drawing.Point(6, 128);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(81, 13);
            this.lblSeatNumber.TabIndex = 12;
            this.lblSeatNumber.Text = "Numero Butaca";
            // 
            // numericUpDownEditSeatNumber
            // 
            this.numericUpDownEditSeatNumber.Location = new System.Drawing.Point(8, 144);
            this.numericUpDownEditSeatNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEditSeatNumber.Name = "numericUpDownEditSeatNumber";
            this.numericUpDownEditSeatNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEditSeatNumber.TabIndex = 13;
            this.numericUpDownEditSeatNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addSeatGroupBox
            // 
            this.addSeatGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.addSeatGroupBox.Controls.Add(this.lblPriceAddSeat);
            this.addSeatGroupBox.Controls.Add(this.numericUpDownAddSeatNumber);
            this.addSeatGroupBox.Controls.Add(this.numericPriceAddSeat);
            this.addSeatGroupBox.Controls.Add(this.label1);
            this.addSeatGroupBox.Controls.Add(this.numericUpDownAddRow);
            this.addSeatGroupBox.Controls.Add(this.lblRowAddSeat);
            this.addSeatGroupBox.Controls.Add(this.btnAddSeat);
            this.addSeatGroupBox.ForeColor = System.Drawing.Color.White;
            this.addSeatGroupBox.Location = new System.Drawing.Point(575, 183);
            this.addSeatGroupBox.Name = "addSeatGroupBox";
            this.addSeatGroupBox.Size = new System.Drawing.Size(140, 279);
            this.addSeatGroupBox.TabIndex = 35;
            this.addSeatGroupBox.TabStop = false;
            this.addSeatGroupBox.Text = "Afegir butaca";
            // 
            // numericUpDownAddSeatNumber
            // 
            this.numericUpDownAddSeatNumber.Location = new System.Drawing.Point(7, 143);
            this.numericUpDownAddSeatNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddSeatNumber.Name = "numericUpDownAddSeatNumber";
            this.numericUpDownAddSeatNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAddSeatNumber.TabIndex = 32;
            this.numericUpDownAddSeatNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Numero Butaca";
            // 
            // numericUpDownAddRow
            // 
            this.numericUpDownAddRow.Location = new System.Drawing.Point(7, 102);
            this.numericUpDownAddRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddRow.Name = "numericUpDownAddRow";
            this.numericUpDownAddRow.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAddRow.TabIndex = 30;
            this.numericUpDownAddRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRowAddSeat
            // 
            this.lblRowAddSeat.AutoSize = true;
            this.lblRowAddSeat.BackColor = System.Drawing.Color.Transparent;
            this.lblRowAddSeat.ForeColor = System.Drawing.Color.White;
            this.lblRowAddSeat.Location = new System.Drawing.Point(5, 86);
            this.lblRowAddSeat.Name = "lblRowAddSeat";
            this.lblRowAddSeat.Size = new System.Drawing.Size(23, 13);
            this.lblRowAddSeat.TabIndex = 29;
            this.lblRowAddSeat.Text = "Fila";
            // 
            // lblPriceAddSeat
            // 
            this.lblPriceAddSeat.AutoSize = true;
            this.lblPriceAddSeat.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceAddSeat.ForeColor = System.Drawing.Color.White;
            this.lblPriceAddSeat.Location = new System.Drawing.Point(6, 38);
            this.lblPriceAddSeat.Name = "lblPriceAddSeat";
            this.lblPriceAddSeat.Size = new System.Drawing.Size(29, 13);
            this.lblPriceAddSeat.TabIndex = 29;
            this.lblPriceAddSeat.Text = "Preu";
            // 
            // RoomDistributionEditorModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eventology.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(747, 477);
            this.Controls.Add(this.addSeatGroupBox);
            this.Controls.Add(this.btnSaveDistribution);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.numericPriceEditSeat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.roomPictureBox);
            this.Controls.Add(this.editSeatGroupbox);
            this.Controls.Add(this.groupBoxAmountSeats);
            this.Name = "RoomDistributionEditorModal";
            this.Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceEditSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceAddSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).EndInit();
            this.editSeatGroupbox.ResumeLayout(false);
            this.editSeatGroupbox.PerformLayout();
            this.groupBoxAmountSeats.ResumeLayout(false);
            this.groupBoxAmountSeats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditSeatNumber)).EndInit();
            this.addSeatGroupBox.ResumeLayout(false);
            this.addSeatGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSeatNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label qtySeat;
        private System.Windows.Forms.Label lblSeatsAmount;
        private System.Windows.Forms.NumericUpDown numericPriceEditSeat;
        private System.Windows.Forms.Button btnDeleteSeat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericPriceAddSeat;
        private System.Windows.Forms.PictureBox roomPictureBox;
        private System.Windows.Forms.Button btnAddSeat;
        private System.Windows.Forms.GroupBox editSeatGroupbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxAmountSeats;
        private System.Windows.Forms.Button btnSaveDistribution;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.NumericUpDown numericUpDownEditRow;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownEditSeatNumber;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox addSeatGroupBox;
        private System.Windows.Forms.Label lblPriceAddSeat;
        private System.Windows.Forms.NumericUpDown numericUpDownAddSeatNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownAddRow;
        private System.Windows.Forms.Label lblRowAddSeat;
    }
}