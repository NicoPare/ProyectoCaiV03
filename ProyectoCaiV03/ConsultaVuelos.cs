using ProyectoCaiV03.Entidades;
using ProyectoCaiV03.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ProyectoCaiV03
{
    public partial class ConsultaVuelos : Form
    {


        public ConsultaVuelos()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario ConsultaVuelos
            this.Close();
        }

        // Mensaje del formulario
        private void ConsultaVuelosForm_Load(object sender, EventArgs e)
        {            
            lblMensaje.Text = "Ingrese los siguientes datos para consultar disponibilidad de vuelos:";
        }


        private void botonBuscar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string origen = txtOrigen.Text;
            string destino = txtDestino.Text;
            DateTime fechaIda = dtpFechaIda.Value;
            DateTime? fechaVuelta = dtpFechaVuelta.Checked ? (DateTime?)dtpFechaVuelta.Value : null;
            int cantidadAdultos = (int)numAdultos.Value;
            int cantidadMenores = (int)numMenores.Value;
            int cantidadInfantes = (int)numInfantes.Value;

            /*
            // Llamar al método ConsultarVuelos de la clase ModuloProductos

            // Crear una instancia de la clase ModuloProductos
            ModuloProductos moduloProductos = new ModuloProductos();
            List<Vuelo> vuelosConsultados = moduloProductos.ConsultarVuelos(origen, destino, fechaIda, fechaVuelta, cantidadAdultos, cantidadMenores, cantidadInfantes);

            // Crear una instancia del formulario VuelosConsultados
            VuelosConsultados formVuelosConsultados = new VuelosConsultados(vuelosConsultados);

            // Mostrar el formulario VuelosConsultados
            formVuelosConsultados.Show();*/

            // Realizar la lógica de consulta y mostrar los resultados

            // ...

            // Llamar al método ConsultarVuelos de la clase ModuloProductos
            ModuloProductos moduloProductos = new ModuloProductos();
            List<dynamic> vuelosDisponibles = moduloProductos.ConsultarVuelos(origen, destino, fechaIda, fechaVuelta, cantidadAdultos, cantidadMenores, cantidadInfantes);

            // Abrir el formulario VuelosConsultados y pasarle los resultados
            VuelosConsultados vuelosConsultadosForm = new VuelosConsultados(vuelosDisponibles);
            vuelosConsultadosForm.Show();

            // Mostrar mensaje de éxito y cerrar el formulario
            MessageBox.Show("Consulta de vuelos realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }


    }
}
