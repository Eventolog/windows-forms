namespace Eventology.Forms.RoomsForm
{
    partial class RoomDistributionEditorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.inputPriceEdit = new System.Windows.Forms.NumericUpDown();
            this.deleteSeat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.roomPictureBox = new System.Windows.Forms.PictureBox();
            this.btnAddSeat = new System.Windows.Forms.Button();
            this.editSeatGroupbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAmountSeats = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputPriceEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).BeginInit();
            this.editSeatGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.BackColor = System.Drawing.Color.Transparent;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(185, 39);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(276, 36);
            this.lblEventName.TabIndex = 30;
            this.lblEventName.Text = "Cinema a la fresca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(185, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Editor d\'escenari per l\'event:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(605, 307);
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
            this.qtySeat.Location = new System.Drawing.Point(708, 114);
            this.qtySeat.Name = "qtySeat";
            this.qtySeat.Size = new System.Drawing.Size(13, 13);
            this.qtySeat.TabIndex = 27;
            this.qtySeat.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(603, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantitat butaques:";
            // 
            // inputPriceEdit
            // 
            this.inputPriceEdit.Location = new System.Drawing.Point(602, 237);
            this.inputPriceEdit.Name = "inputPriceEdit";
            this.inputPriceEdit.Size = new System.Drawing.Size(127, 20);
            this.inputPriceEdit.TabIndex = 25;
            // 
            // deleteSeat
            // 
            this.deleteSeat.BackColor = System.Drawing.Color.White;
            this.deleteSeat.Location = new System.Drawing.Point(195, 114);
            this.deleteSeat.Name = "deleteSeat";
            this.deleteSeat.Size = new System.Drawing.Size(132, 41);
            this.deleteSeat.TabIndex = 24;
            this.deleteSeat.Text = "Eliminar butaca";
            this.deleteSeat.UseVisualStyleBackColor = false;
            this.deleteSeat.Click += new System.EventHandler(this.deleteSeat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(766, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 362);
            this.textBox1.TabIndex = 23;
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(463, 135);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(120, 20);
            this.numericPrice.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(462, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Preu butaca a afegir";
            // 
            // roomPictureBox
            // 
            this.roomPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roomPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPictureBox.Location = new System.Drawing.Point(189, 182);
            this.roomPictureBox.Name = "roomPictureBox";
            this.roomPictureBox.Size = new System.Drawing.Size(400, 279);
            this.roomPictureBox.TabIndex = 20;
            this.roomPictureBox.TabStop = false;
            // 
            // btnAddSeat
            // 
            this.btnAddSeat.BackColor = System.Drawing.Color.White;
            this.btnAddSeat.Location = new System.Drawing.Point(337, 115);
            this.btnAddSeat.Name = "btnAddSeat";
            this.btnAddSeat.Size = new System.Drawing.Size(115, 41);
            this.btnAddSeat.TabIndex = 19;
            this.btnAddSeat.Text = "Afegir butaca";
            this.btnAddSeat.UseVisualStyleBackColor = false;
            this.btnAddSeat.Click += new System.EventHandler(this.addSeat_Click);
            // 
            // editSeatGroupbox
            // 
            this.editSeatGroupbox.BackColor = System.Drawing.Color.Transparent;
            this.editSeatGroupbox.Controls.Add(this.label2);
            this.editSeatGroupbox.ForeColor = System.Drawing.Color.White;
            this.editSeatGroupbox.Location = new System.Drawing.Point(595, 182);
            this.editSeatGroupbox.Name = "editSeatGroupbox";
            this.editSeatGroupbox.Size = new System.Drawing.Size(146, 170);
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
            this.groupBoxAmountSeats.Location = new System.Drawing.Point(595, 99);
            this.groupBoxAmountSeats.Name = "groupBoxAmountSeats";
            this.groupBoxAmountSeats.Size = new System.Drawing.Size(146, 68);
            this.groupBoxAmountSeats.TabIndex = 32;
            this.groupBoxAmountSeats.TabStop = false;
            this.groupBoxAmountSeats.UseCompatibleTextRendering = true;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxActions.Location = new System.Drawing.Point(189, 99);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(400, 68);
            this.groupBoxActions.TabIndex = 33;
            this.groupBoxActions.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(595, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 52);
            this.button1.TabIndex = 34;
            this.button1.Text = "Guardar Distribucio";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RoomDistributionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eventology.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1065, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.qtySeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPriceEdit);
            this.Controls.Add(this.deleteSeat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomPictureBox);
            this.Controls.Add(this.btnAddSeat);
            this.Controls.Add(this.editSeatGroupbox);
            this.Controls.Add(this.groupBoxAmountSeats);
            this.Controls.Add(this.groupBoxActions);
            this.Name = "RoomDistributionEditorForm";
            this.Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.inputPriceEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).EndInit();
            this.editSeatGroupbox.ResumeLayout(false);
            this.editSeatGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label qtySeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputPriceEdit;
        private System.Windows.Forms.Button deleteSeat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox roomPictureBox;
        private System.Windows.Forms.Button btnAddSeat;
        private System.Windows.Forms.GroupBox editSeatGroupbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxAmountSeats;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button button1;
    }
}