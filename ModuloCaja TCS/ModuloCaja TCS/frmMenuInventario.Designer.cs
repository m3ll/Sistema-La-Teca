namespace Sistema_de_inventario
{
    partial class frmMenuInventario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuInventario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInventarioCabana = new System.Windows.Forms.Button();
            this.btnInventarioRest = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.sALIRToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.salirToolStripMenuItem.Text = "AYUDA";
            // 
            // sALIRToolStripMenuItem1
            // 
            this.sALIRToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            this.sALIRToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.sALIRToolStripMenuItem1.Text = "SALIR";
            this.sALIRToolStripMenuItem1.Click += new System.EventHandler(this.sALIRToolStripMenuItem1_Click);
            // 
            // btnInventarioCabana
            // 
            this.btnInventarioCabana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarioCabana.Image = ((System.Drawing.Image)(resources.GetObject("btnInventarioCabana.Image")));
            this.btnInventarioCabana.Location = new System.Drawing.Point(416, 44);
            this.btnInventarioCabana.Name = "btnInventarioCabana";
            this.btnInventarioCabana.Size = new System.Drawing.Size(232, 186);
            this.btnInventarioCabana.TabIndex = 3;
            this.btnInventarioCabana.Text = "Invetario de las cabañas";
            this.btnInventarioCabana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInventarioCabana.UseVisualStyleBackColor = true;
            this.btnInventarioCabana.Click += new System.EventHandler(this.btnInventarioCabana_Click);
            // 
            // btnInventarioRest
            // 
            this.btnInventarioRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarioRest.Image = ((System.Drawing.Image)(resources.GetObject("btnInventarioRest.Image")));
            this.btnInventarioRest.Location = new System.Drawing.Point(44, 44);
            this.btnInventarioRest.Name = "btnInventarioRest";
            this.btnInventarioRest.Size = new System.Drawing.Size(233, 186);
            this.btnInventarioRest.TabIndex = 2;
            this.btnInventarioRest.Text = "Invetario del Restaurante";
            this.btnInventarioRest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInventarioRest.UseVisualStyleBackColor = true;
            this.btnInventarioRest.Click += new System.EventHandler(this.btnInventarioRest_Click);
            // 
            // frmMenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 242);
            this.Controls.Add(this.btnInventarioCabana);
            this.Controls.Add(this.btnInventarioRest);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuInventario";
            this.Text = "Menu Inventario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem1;
        private System.Windows.Forms.Button btnInventarioRest;
        private System.Windows.Forms.Button btnInventarioCabana;


    }
}

