namespace Forms
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaUniversidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUniversidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.públicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaUniversidadesToolStripMenuItem,
            this.listaUniversidadesToolStripMenuItem,
            this.consultaDeAlumnosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaUniversidadesToolStripMenuItem
            // 
            this.altaUniversidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.públicaToolStripMenuItem,
            this.privadaToolStripMenuItem});
            this.altaUniversidadesToolStripMenuItem.Name = "altaUniversidadesToolStripMenuItem";
            this.altaUniversidadesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.altaUniversidadesToolStripMenuItem.Text = "Alta Universidades";
            // 
            // listaUniversidadesToolStripMenuItem
            // 
            this.listaUniversidadesToolStripMenuItem.Name = "listaUniversidadesToolStripMenuItem";
            this.listaUniversidadesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.listaUniversidadesToolStripMenuItem.Text = "Lista Universidades";
            this.listaUniversidadesToolStripMenuItem.Click += new System.EventHandler(this.listaUniversidadesToolStripMenuItem_Click);
            // 
            // consultaDeAlumnosToolStripMenuItem
            // 
            this.consultaDeAlumnosToolStripMenuItem.Name = "consultaDeAlumnosToolStripMenuItem";
            this.consultaDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.consultaDeAlumnosToolStripMenuItem.Text = "Cantidad de Alumnos";
            this.consultaDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeAlumnosToolStripMenuItem_Click);
            // 
            // públicaToolStripMenuItem
            // 
            this.públicaToolStripMenuItem.Name = "públicaToolStripMenuItem";
            this.públicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.públicaToolStripMenuItem.Text = "Pública";
            this.públicaToolStripMenuItem.Click += new System.EventHandler(this.públicaToolStripMenuItem_Click);
            // 
            // privadaToolStripMenuItem
            // 
            this.privadaToolStripMenuItem.Name = "privadaToolStripMenuItem";
            this.privadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.privadaToolStripMenuItem.Text = "Privada";
            this.privadaToolStripMenuItem.Click += new System.EventHandler(this.privadaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 218);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaUniversidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaUniversidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem públicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privadaToolStripMenuItem;
    }
}