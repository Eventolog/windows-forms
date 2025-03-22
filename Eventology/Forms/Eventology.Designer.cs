namespace Eventology
{
    partial class Eventology
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 46);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1081, 544);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(30, 12);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(75, 23);
            this.buttonInit.TabIndex = 1;
            this.buttonInit.Text = "Inici";
            this.buttonInit.UseVisualStyleBackColor = true;
            // 
            // buttonRooms
            // 
            this.buttonRooms.Location = new System.Drawing.Point(295, 12);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(75, 23);
            this.buttonRooms.TabIndex = 2;
            this.buttonRooms.Text = "Sales";
            this.buttonRooms.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(431, 12);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonUsers.TabIndex = 3;
            this.buttonUsers.Text = "Usuaris";
            this.buttonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(157, 12);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(93, 23);
            this.buttonEvents.TabIndex = 4;
            this.buttonEvents.Text = "Esdeveniments";
            this.buttonEvents.UseVisualStyleBackColor = true;
            // 
            // Eventology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 591);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonRooms);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.mainPanel);
            this.Name = "Eventology";
            this.Text = "Eventology";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonEvents;
    }
}

