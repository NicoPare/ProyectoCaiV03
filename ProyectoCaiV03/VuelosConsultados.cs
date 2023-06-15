using ProyectoCaiV03.Entidades;
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
    public partial class VuelosConsultados : Form
    {
        private List<dynamic> vuelosDisponibles;

        public VuelosConsultados(List<dynamic> vuelosDisponibles)
        {
            InitializeComponent();
            this.vuelosDisponibles = vuelosDisponibles;
        }

        private void VuelosConsultados_Load(object sender, EventArgs e)
        {
            // Mostrar los datos en el control adecuado (por ejemplo, ListBox, DataGridView)
            foreach (dynamic vuelo in vuelosDisponibles)
            {
                listBoxVuelos.Items.Add(vuelo); // Agregar el vuelo al ListBox
            }
        }
    }
}
