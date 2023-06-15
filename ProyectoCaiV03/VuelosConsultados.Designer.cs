using ProyectoCaiV03.Entidades;
using System.Xml.Linq;

namespace ProyectoCaiV03
{
    partial class VuelosConsultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxVuelos;
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

        //#region Código generado por el Diseñador de Windows Forms

        /*private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLlegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.fechaLlegadaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueloBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // origenDataGridViewTextBoxColumn
            // 
            this.origenDataGridViewTextBoxColumn.DataPropertyName = "Origen";
            this.origenDataGridViewTextBoxColumn.HeaderText = "Origen";
            this.origenDataGridViewTextBoxColumn.Name = "origenDataGridViewTextBoxColumn";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // fechaSalidaDataGridViewTextBoxColumn
            // 
            this.fechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.HeaderText = "FechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.Name = "fechaSalidaDataGridViewTextBoxColumn";
            // 
            // fechaLlegadaDataGridViewTextBoxColumn
            // 
            this.fechaLlegadaDataGridViewTextBoxColumn.DataPropertyName = "FechaLlegada";
            this.fechaLlegadaDataGridViewTextBoxColumn.HeaderText = "FechaLlegada";
            this.fechaLlegadaDataGridViewTextBoxColumn.Name = "fechaLlegadaDataGridViewTextBoxColumn";
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(ProyectoCaiV03.Entidades.Vuelo);
            // 
            // VuelosConsultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VuelosConsultados";
            this.Text = "Vuelos Consultados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

//#endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLlegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vueloBindingSource;*/

        private void InitializeComponent()
        {
            this.listBoxVuelos = new System.Windows.Forms.ListBox();
            // Otros componentes y configuraciones del formulario...
            // ...

            // Configuración del ListBox
            this.listBoxVuelos.FormattingEnabled = true;
            this.listBoxVuelos.Location = new System.Drawing.Point(10, 10);
            this.listBoxVuelos.Name = "listBoxVuelos";
            this.listBoxVuelos.Size = new System.Drawing.Size(200, 200);
            this.listBoxVuelos.TabIndex = 0;

            // Agregar el ListBox al formulario
            this.Controls.Add(this.listBoxVuelos);
        }

        // Resto del código de la clase...
        // ...

        // Método para agregar vuelo al ListBox
        private void AgregarVueloAlListBox(Vuelo vuelo)
        {
            listBoxVuelos.Items.Add(vuelo);
        }
    }
}