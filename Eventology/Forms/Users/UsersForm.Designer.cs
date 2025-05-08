namespace Eventology.Forms
{
    partial class UsersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewOrganizers = new System.Windows.Forms.DataGridView();
            this.buttonAddOrganizer = new System.Windows.Forms.Button();
            this.buttonDeleteOrganizer = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crea un Organitzador";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(178, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(178, 166);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(178, 216);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // dataGridViewOrganizers
            // 
            this.dataGridViewOrganizers.AllowUserToAddRows = false;
            this.dataGridViewOrganizers.AllowUserToDeleteRows = false;
            this.dataGridViewOrganizers.AllowUserToResizeColumns = false;
            this.dataGridViewOrganizers.AllowUserToResizeRows = false;
            this.dataGridViewOrganizers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrganizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganizers.Location = new System.Drawing.Point(438, 113);
            this.dataGridViewOrganizers.Name = "dataGridViewOrganizers";
            this.dataGridViewOrganizers.ReadOnly = true;
            this.dataGridViewOrganizers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrganizers.Size = new System.Drawing.Size(521, 330);
            this.dataGridViewOrganizers.TabIndex = 4;
            this.dataGridViewOrganizers.SelectionChanged += new System.EventHandler(this.dataGridViewOrganizers_SelectionChanged);
            // 
            // buttonAddOrganizer
            // 
            this.buttonAddOrganizer.Location = new System.Drawing.Point(303, 279);
            this.buttonAddOrganizer.Name = "buttonAddOrganizer";
            this.buttonAddOrganizer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOrganizer.TabIndex = 5;
            this.buttonAddOrganizer.Text = "Guardar";
            this.buttonAddOrganizer.UseVisualStyleBackColor = true;
            this.buttonAddOrganizer.Click += new System.EventHandler(this.buttonAddOrganizer_Click);
            // 
            // buttonDeleteOrganizer
            // 
            this.buttonDeleteOrganizer.Location = new System.Drawing.Point(974, 115);
            this.buttonDeleteOrganizer.Name = "buttonDeleteOrganizer";
            this.buttonDeleteOrganizer.Size = new System.Drawing.Size(61, 23);
            this.buttonDeleteOrganizer.TabIndex = 6;
            this.buttonDeleteOrganizer.Text = "Eliminar";
            this.buttonDeleteOrganizer.UseVisualStyleBackColor = true;
            this.buttonDeleteOrganizer.Click += new System.EventHandler(this.buttonDeleteOrganizer_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(58, 115);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 16);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Nom";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(58, 167);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 16);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Correu";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(58, 217);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 16);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Contrasenya";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(195, 279);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 11;
            this.buttonClean.Text = "Netejar";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eventology.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1065, 505);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonDeleteOrganizer);
            this.Controls.Add(this.buttonAddOrganizer);
            this.Controls.Add(this.dataGridViewOrganizers);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "UsersForm";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.DataGridView dataGridViewOrganizers;
        private System.Windows.Forms.Button buttonAddOrganizer;
        private System.Windows.Forms.Button buttonDeleteOrganizer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonClean;
    }
}