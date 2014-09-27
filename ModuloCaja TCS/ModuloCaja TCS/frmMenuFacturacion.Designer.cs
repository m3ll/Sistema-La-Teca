namespace ModuloCaja_TCS
{
    partial class frmMenuFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuFacturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturarReservacion = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnFacturarRestaurate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Facturacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnFacturarReservacion);
            this.groupBox1.Controls.Add(this.btnInformes);
            this.groupBox1.Controls.Add(this.btnFacturarRestaurate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ModuloCaja_TCS.Properties.Resources._10644678_735598909821137_1933969775735654475_o;
            this.pictureBox1.Location = new System.Drawing.Point(12, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ModuloCaja_TCS.Properties.Resources.sign_out;
            this.btnSalir.Location = new System.Drawing.Point(546, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 71);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFacturarReservacion
            // 
            this.btnFacturarReservacion.Image = global::ModuloCaja_TCS.Properties.Resources.Hotel2;
            this.btnFacturarReservacion.Location = new System.Drawing.Point(231, 24);
            this.btnFacturarReservacion.Name = "btnFacturarReservacion";
            this.btnFacturarReservacion.Size = new System.Drawing.Size(119, 71);
            this.btnFacturarReservacion.TabIndex = 1;
            this.btnFacturarReservacion.Text = "Reservacion";
            this.btnFacturarReservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFacturarReservacion.UseVisualStyleBackColor = true;
            // 
            // btnInformes
            // 
            this.btnInformes.Image = global::ModuloCaja_TCS.Properties.Resources.system_report;
            this.btnInformes.Location = new System.Drawing.Point(389, 24);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(126, 71);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // btnFacturarRestaurate
            // 
            this.btnFacturarRestaurate.Image = global::ModuloCaja_TCS.Properties.Resources.restaurant;
            this.btnFacturarRestaurate.Location = new System.Drawing.Point(73, 24);
            this.btnFacturarRestaurate.Name = "btnFacturarRestaurate";
            this.btnFacturarRestaurate.Size = new System.Drawing.Size(119, 71);
            this.btnFacturarRestaurate.TabIndex = 0;
            this.btnFacturarRestaurate.Text = "Restaurante";
            this.btnFacturarRestaurate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFacturarRestaurate.UseVisualStyleBackColor = true;
            this.btnFacturarRestaurate.Click += new System.EventHandler(this.btnFacturarRestaurate_Click);
            // 
            // frmMenuFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuFacturacion";
            this.Text = "Menu Facturacion";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFacturarReservacion;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnFacturarRestaurate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}