namespace Eventology
{
    partial class EventologyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventologyForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSeparation = new System.Windows.Forms.Label();
            this.labelSeparation2 = new System.Windows.Forms.Label();
            this.labelSeparation3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1081, 544);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonInit
            // 
            this.buttonInit.BackColor = System.Drawing.Color.Transparent;
            this.buttonInit.Location = new System.Drawing.Point(17, 5);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(75, 23);
            this.buttonInit.TabIndex = 1;
            this.buttonInit.Text = "Inici";
            this.buttonInit.UseVisualStyleBackColor = false;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Location = new System.Drawing.Point(282, 5);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(75, 23);
            this.buttonRooms.TabIndex = 3;
            this.buttonRooms.Text = "Sales";
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(412, 5);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonUsers.TabIndex = 4;
            this.buttonUsers.Text = "Usuaris";
            this.buttonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(144, 5);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(93, 23);
            this.buttonEvents.TabIndex = 2;
            this.buttonEvents.Text = "Esdeveniments";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(985, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Sortir";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSeparation
            // 
            this.labelSeparation.AutoSize = true;
            this.labelSeparation.Location = new System.Drawing.Point(114, 10);
            this.labelSeparation.Name = "labelSeparation";
            this.labelSeparation.Size = new System.Drawing.Size(9, 13);
            this.labelSeparation.TabIndex = 6;
            this.labelSeparation.Text = "|";
            // 
            // labelSeparation2
            // 
            this.labelSeparation2.AutoSize = true;
            this.labelSeparation2.Location = new System.Drawing.Point(254, 10);
            this.labelSeparation2.Name = "labelSeparation2";
            this.labelSeparation2.Size = new System.Drawing.Size(9, 13);
            this.labelSeparation2.TabIndex = 7;
            this.labelSeparation2.Text = "|";
            // 
            // labelSeparation3
            // 
            this.labelSeparation3.AutoSize = true;
            this.labelSeparation3.Location = new System.Drawing.Point(379, 10);
            this.labelSeparation3.Name = "labelSeparation3";
            this.labelSeparation3.Size = new System.Drawing.Size(9, 13);
            this.labelSeparation3.TabIndex = 8;
            this.labelSeparation3.Text = "|";
            // 
            // EventologyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 576);
            this.Controls.Add(this.labelSeparation3);
            this.Controls.Add(this.labelSeparation2);
            this.Controls.Add(this.labelSeparation);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonRooms);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventologyForm";
            this.Text = "Eventology";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSeparation;
        private System.Windows.Forms.Label labelSeparation2;
        private System.Windows.Forms.Label labelSeparation3;
    }
}

