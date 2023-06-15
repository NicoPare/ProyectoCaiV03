using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCaiV03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonConsultarVuelos_Click(object sender, EventArgs e)
        {
            // Ocultar la ventana actual (Form1)
            this.Hide();

            // Crear una instancia del formulario ConsultaVuelosForm
            ConsultaVuelos consultaVuelosForm = new ConsultaVuelos();

            // Mostrar el formulario ConsultaVuelosForm como diálogo
            DialogResult result = consultaVuelosForm.ShowDialog();

            // Verificar el resultado del diálogo
            if (result == DialogResult.OK)
            {
                // Mostrar la ventana actual (Form1)
                this.Show();
            }
        }

        private void botonConsultarAlojamientos_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual (Form1)
            this.Hide();

            // Mostrar el formulario ConsultaAlojamiento
            ConsultaAlojamiento consultaAlojamientoForm = new ConsultaAlojamiento();
            consultaAlojamientoForm.ShowDialog();

            // Volver a mostrar el formulario actual (Form1) después de cerrar ConsultaAlojamiento
            this.Show();
        }

    }
}
