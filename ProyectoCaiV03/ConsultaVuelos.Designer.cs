namespace ProyectoCaiV03
{
    partial class ConsultaVuelos
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

        /*
        private void InitializeComponent()
        {
            this.botonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(82, 110);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(150, 50);
            this.botonVolver.TabIndex = 1;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // ConsultaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 191);
            this.Controls.Add(this.botonVolver);
            this.Name = "ConsultaVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vuelos";
            this.ResumeLayout(false);

        }
        */

        private void InitializeComponent()
        {
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblFechaIda = new System.Windows.Forms.Label();
            this.dtpFechaIda = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVuelta = new System.Windows.Forms.Label();
            this.dtpFechaVuelta = new System.Windows.Forms.DateTimePicker();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.numAdultos = new System.Windows.Forms.NumericUpDown();
            this.lblMenores = new System.Windows.Forms.Label();
            this.numMenores = new System.Windows.Forms.NumericUpDown();
            this.lblInfantes = new System.Windows.Forms.Label();
            this.numInfantes = new System.Windows.Forms.NumericUpDown();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInfantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(230, 17);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Ingrese los siguientes datos para consultar disponibilidad de vuelos";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(12, 40);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(49, 17);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(96, 37);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(200, 22);
            this.txtOrigen.TabIndex = 2;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(12, 68);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(58, 17);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(96, 65);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(200, 22);
            this.txtDestino.TabIndex = 4;
            // 
            // lblFechaIda
            // 
            this.lblFechaIda.AutoSize = true;
            this.lblFechaIda.Location = new System.Drawing.Point(12, 96);
            this.lblFechaIda.Name = "lblFechaIda";
            this.lblFechaIda.Size = new System.Drawing.Size(76, 17);
            this.lblFechaIda.TabIndex = 5;
            this.lblFechaIda.Text = "Fecha Ida:";
            // 
            // dtpFechaIda
            // 
            this.dtpFechaIda.Location = new System.Drawing.Point(96, 93);
            this.dtpFechaIda.Name = "dtpFechaIda";
            this.dtpFechaIda.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaIda.TabIndex = 6;
            // 
            // lblFechaVuelta
            // 
            this.lblFechaVuelta.AutoSize = true;
            this.lblFechaVuelta.Location = new System.Drawing.Point(12, 124);
            this.lblFechaVuelta.Name = "lblFechaVuelta";
            this.lblFechaVuelta.Size = new System.Drawing.Size(97, 17);
            this.lblFechaVuelta.TabIndex = 7;
            this.lblFechaVuelta.Text = "Fecha Vuelta:";
            // 
            // dtpFechaVuelta
            // 
            this.dtpFechaVuelta.Location = new System.Drawing.Point(115, 121);
            this.dtpFechaVuelta.Name = "dtpFechaVuelta";
            this.dtpFechaVuelta.Size = new System.Drawing.Size(181, 22);
            this.dtpFechaVuelta.TabIndex = 8;
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(12, 152);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(57, 17);
            this.lblAdultos.TabIndex = 9;
            this.lblAdultos.Text = "Adultos:";
            // 
            // numAdultos
            // 
            this.numAdultos.Location = new System.Drawing.Point(96, 150);
            this.numAdultos.Name = "numAdultos";
            this.numAdultos.Size = new System.Drawing.Size(50, 22);
            this.numAdultos.TabIndex = 10;
            // 
            // lblMenores
            // 
            this.lblMenores.AutoSize = true;
            this.lblMenores.Location = new System.Drawing.Point(12, 180);
            this.lblMenores.Name = "lblMenores";
            this.lblMenores.Size = new System.Drawing.Size(64, 17);
            this.lblMenores.TabIndex = 11;
            this.lblMenores.Text = "Menores:";
            // 
            // numMenores
            // 
            this.numMenores.Location = new System.Drawing.Point(96, 178);
            this.numMenores.Name = "numMenores";
            this.numMenores.Size = new System.Drawing.Size(50, 22);
            this.numMenores.TabIndex = 12;
            // 
            // lblInfantes
            // 
            this.lblInfantes.AutoSize = true;
            this.lblInfantes.Location = new System.Drawing.Point(12, 208);
            this.lblInfantes.Name = "lblInfantes";
            this.lblInfantes.Size = new System.Drawing.Size(59, 17);
            this.lblInfantes.TabIndex = 13;
            this.lblInfantes.Text = "Infantes:";
            // 
            // numInfantes
            // 
            this.numInfantes.Location = new System.Drawing.Point(96, 206);
            this.numInfantes.Name = "numInfantes";
            this.numInfantes.Size = new System.Drawing.Size(50, 22);
            this.numInfantes.TabIndex = 14;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(15, 245);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 15;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(96, 245);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 16;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // ConsultaVuelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 282);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.numInfantes);
            this.Controls.Add(this.lblInfantes);
            this.Controls.Add(this.numMenores);
            this.Controls.Add(this.lblMenores);
            this.Controls.Add(this.numAdultos);
            this.Controls.Add(this.lblAdultos);
            this.Controls.Add(this.dtpFechaVuelta);
            this.Controls.Add(this.lblFechaVuelta);
            this.Controls.Add(this.dtpFechaIda);
            this.Controls.Add(this.lblFechaIda);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblMensaje);
            this.Name = "ConsultaVuelosForm";
            this.Text = "Consulta de Vuelos";
            this.Load += new System.EventHandler(this.ConsultaVuelosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInfantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblFechaIda;
        private System.Windows.Forms.DateTimePicker dtpFechaIda;
        private System.Windows.Forms.Label lblFechaVuelta;
        private System.Windows.Forms.DateTimePicker dtpFechaVuelta;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.NumericUpDown numAdultos;
        private System.Windows.Forms.Label lblMenores;
        private System.Windows.Forms.NumericUpDown numMenores;
        private System.Windows.Forms.Label lblInfantes;
        private System.Windows.Forms.NumericUpDown numInfantes;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonVolver;
    }
}
