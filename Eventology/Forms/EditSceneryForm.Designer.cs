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
            ((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
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
            this.textBox1.Location = new System.Drawing.Point(462, 149);
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
            this.deleteSeat.Text = "Eliminar element";
            this.deleteSeat.UseVisualStyleBackColor = true;
            this.deleteSeat.Click += new System.EventHandler(this.deleteSeat_Click);
            // 
            // EditSceneryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
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
    }
}