namespace ProyectoCaiV03
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.botonConsultarVuelos = new System.Windows.Forms.Button();
            this.botonConsultarAlojamientos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonConsultarVuelos
            // 
            this.botonConsultarVuelos.Location = new System.Drawing.Point(82, 40);
            this.botonConsultarVuelos.Name = "botonConsultarVuelos";
            this.botonConsultarVuelos.Size = new System.Drawing.Size(150, 50);
            this.botonConsultarVuelos.TabIndex = 0;
            this.botonConsultarVuelos.Text = "Consultar disponibilidad de vuelos";
            this.botonConsultarVuelos.UseVisualStyleBackColor = true;
            this.botonConsultarVuelos.Click += new System.EventHandler(this.botonConsultarVuelos_Click);
            // 
            // botonConsultarAlojamientos
            // 
            this.botonConsultarAlojamientos.Location = new System.Drawing.Point(82, 110);
            this.botonConsultarAlojamientos.Name = "botonConsultarAlojamientos";
            this.botonConsultarAlojamientos.Size = new System.Drawing.Size(150, 50);
            this.botonConsultarAlojamientos.TabIndex = 1;
            this.botonConsultarAlojamientos.Text = "Consultar disponibilidad de alojamientos";
            this.botonConsultarAlojamientos.UseVisualStyleBackColor = true;
            this.botonConsultarAlojamientos.Click += new System.EventHandler(this.botonConsultarAlojamientos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 191);
            this.Controls.Add(this.botonConsultarAlojamientos);
            this.Controls.Add(this.botonConsultarVuelos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar disponibilidad";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button botonConsultarVuelos;
        private System.Windows.Forms.Button botonConsultarAlojamientos;
    }
}
