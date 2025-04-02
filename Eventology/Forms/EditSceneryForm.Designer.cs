namespace Eventology.Forms
{
    partial class EditSceneryForm
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
            this.btnAddSeat = new System.Windows.Forms.Button();
            this.roomPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteSeat = new System.Windows.Forms.Button();
            this.lblEditSeat = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qtySeat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSeat
            // 
            this.btnAddSeat.Location = new System.Drawing.Point(171, 66);
            this.btnAddSeat.Name = "btnAddSeat";
            this.btnAddSeat.Size = new System.Drawing.Size(115, 41);
            this.btnAddSeat.TabIndex = 0;
            this.btnAddSeat.Text = "Afegir butaca";
            this.btnAddSeat.UseVisualStyleBackColor = true;
            this.btnAddSeat.Click += new System.EventHandler(this.btnAddSeat_Click);
            // 
            // roomPictureBox
            // 
            this.roomPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roomPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPictureBox.Location = new System.Drawing.Point(23, 132);
            this.roomPictureBox.Name = "roomPictureBox";
            this.roomPictureBox.Size = new System.Drawing.Size(400, 400);
            this.roomPictureBox.TabIndex = 1;
            this.roomPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preu butaca a afegir";
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(304, 87);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(120, 20);
            this.numericPrice.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 512);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // deleteSeat
            // 
            this.deleteSeat.Location = new System.Drawing.Point(23, 66);
            this.deleteSeat.Name = "deleteSeat";
            this.deleteSeat.Size = new System.Drawing.Size(132, 41);
            this.deleteSeat.TabIndex = 6;
            this.deleteSeat.Text = "Eliminar butaca";
            this.deleteSeat.UseVisualStyleBackColor = true;
            this.deleteSeat.Click += new System.EventHandler(this.deleteSeat_Click);
            // 
            // lblEditSeat
            // 
            this.lblEditSeat.AutoSize = true;
            this.lblEditSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSeat.Location = new System.Drawing.Point(441, 132);
            this.lblEditSeat.Name = "lblEditSeat";
            this.lblEditSeat.Size = new System.Drawing.Size(106, 20);
            this.lblEditSeat.TabIndex = 7;
            this.lblEditSeat.Text = "Editar Butaca";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(445, 193);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preu butaca seleccionada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantitat butaques:";
            // 
            // qtySeat
            // 
            this.qtySeat.AutoSize = true;
            this.qtySeat.Location = new System.Drawing.Point(536, 86);
            this.qtySeat.Name = "qtySeat";
            this.qtySeat.Size = new System.Drawing.Size(13, 13);
            this.qtySeat.TabIndex = 11;
            this.qtySeat.Text = "0";
            // 
            // EditSceneryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.qtySeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblEditSeat);
            this.Controls.Add(this.deleteSeat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomPictureBox);
            this.Controls.Add(this.btnAddSeat);
            this.Name = "EditSceneryForm";
            this.Text = "Editor d\'escenaris";
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSeat;
        private System.Windows.Forms.PictureBox roomPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteSeat;
        private System.Windows.Forms.Label lblEditSeat;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label qtySeat;
    }
}