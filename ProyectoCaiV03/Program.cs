using ProyectoCaiV03.Modulos;
using System.Diagnostics;

namespace ProyectoCaiV03
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            // CARGO DATOS EN Productos.json
            ModuloProductos moduloProductos = new ModuloProductos();

            moduloProductos.ProcesarVuelosYAlojamientos();

            // prueba del método ConsultarVuelos()

            // Parámetros de búsqueda de vuelos
            string origen = "Buenos Aires";
            string destino = "Londres";
            DateTime fechaIda = DateTime.Parse("2023-01-06");
            DateTime? fechaVuelta = DateTime.Parse("2023-01-06");
            int cantidadAdultos = 1;
            int cantidadMenores = 0;
            int cantidadInfantes = 0;

            // Consultar vuelos disponibles
            var vuelosDisponibles = moduloProductos.ConsultarVuelos(origen, destino, fechaIda, fechaVuelta, cantidadAdultos, cantidadMenores, cantidadInfantes);

            // Mostrar los vuelos encontrados
            foreach (var vuelo in vuelosDisponibles)
            {
                Debug.WriteLine("Código de vuelo: " + vuelo.CodVuelo);
                Debug.WriteLine("Origen: " + vuelo.Origen);
                Debug.WriteLine("Destino: " + vuelo.Destino);
                Debug.WriteLine("Aerolínea: " + vuelo.Aerolinea);
                Debug.WriteLine("Fecha y hora de salida: " + vuelo.FechaHoraSalida);
                Debug.WriteLine("Fecha y hora de arribo: " + vuelo.FechaHoraArribo);
                Debug.WriteLine("Tiempo de vuelo: " + vuelo.TiempoDeVuelo);
                Debug.WriteLine("-------------------------------------");
            }
            //Debug.WriteLine(vuelosDisponibles);
            //Debug.WriteLine("Los productos se han guardado en el archivo ProductosArchivo.json");

        }
    }
}