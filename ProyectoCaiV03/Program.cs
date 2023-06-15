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
            /*string origen = "Buenos Aires";
            string destino = "Londres";
            DateTime fechaIda = DateTime.Parse("2023-01-06");
            DateTime? fechaVuelta = DateTime.Parse("2023-01-06");
            int cantidadAdultos = 1;
            int cantidadMenores = 0;
            int cantidadInfantes = 0;*/

            // Consultar vuelos disponibles
            //var vuelosDisponibles = moduloProductos.ConsultarVuelos(origen, destino, fechaIda, fechaVuelta, cantidadAdultos, cantidadMenores, cantidadInfantes);

            // Mostrar los vuelos encontrados
            /*foreach (var vuelo in vuelosDisponibles)
            {
                Debug.WriteLine("Código de vuelo: " + vuelo.CodVuelo);
                Debug.WriteLine("Origen: " + vuelo.Origen);
                Debug.WriteLine("Destino: " + vuelo.Destino);
                Debug.WriteLine("Aerolínea: " + vuelo.Aerolinea);
                Debug.WriteLine("Fecha y hora de salida: " + vuelo.FechaHoraSalida);
                Debug.WriteLine("Fecha y hora de arribo: " + vuelo.FechaHoraArribo);
                Debug.WriteLine("Tiempo de vuelo: " + vuelo.TiempoDeVuelo);
                Debug.WriteLine("-------------------------------------");
            }*/
            //Debug.WriteLine(vuelosDisponibles);
            //Debug.WriteLine("Los productos se han guardado en el archivo ProductosArchivo.json");

            
            
            // Crear una instancia de ModuloPresupuesto
            ModuloPresupuesto moduloPresupuesto = new ModuloPresupuesto();

            // Crear una lista de alojamientos y vuelos seleccionados
            List<dynamic> alojamientosSeleccionados = new List<dynamic>();
            List<dynamic> vuelosSeleccionados = new List<dynamic>();

            // Agregar algunos alojamientos seleccionados a la lista
            dynamic alojamiento1 = new
            {
                CodCiudad = "BSA",
                FechaIngreso = "06/01/2023",
                FechaSalida = "06/02/2023",
                NombreAlojamiento = "Hotel ABC",
                Tarifa = 100,
                NombreHabitacion = "Habitación Estándar",
                Calificacion = 4
            };
            alojamientosSeleccionados.Add(alojamiento1);

            dynamic alojamiento2 = new
            {
                CodCiudad = "COD2",
                FechaIngreso = DateTime.Now,
                FechaSalida = DateTime.Now.AddDays(7),
                NombreAlojamiento = "Hotel XYZ",
                Tarifa = 150,
                NombreHabitacion = "Suite",
                Calificacion = 5
            };
            alojamientosSeleccionados.Add(alojamiento2);

            // Agregar algunos vuelos seleccionados a la lista
            dynamic vuelo1 = new
            {
                Origen = "Ciudad A",
                Destino = "Ciudad B",
                FechaHoraSalida = DateTime.Now,
                FechaHoraArribo = DateTime.Now.AddHours(2),
                Aerolinea = "Aerolínea 1",
                Tarifas = new[]
                {
                    new { Precio = 200, ClaseVuelo = "Económica" },
                    new { Precio = 400, ClaseVuelo = "Premium" }
                }
            };
            vuelosSeleccionados.Add(vuelo1);

            dynamic vuelo2 = new
            {
                Origen = "Ciudad B",
                Destino = "Ciudad C",
                FechaHoraSalida = DateTime.Now,
                FechaHoraArribo = DateTime.Now.AddHours(3),
                Aerolinea = "Aerolínea 2",
                Tarifas = new[]
                {
                    new { Precio = 300, ClaseVuelo = "Económica" },
                    new { Precio = 500, ClaseVuelo = "Premium" }
                }
            };
            vuelosSeleccionados.Add(vuelo2);

            // Ejecutar el método GuardarPresupuesto
            moduloPresupuesto.GuardarPresupuesto(alojamientosSeleccionados, vuelosSeleccionados);

            Console.WriteLine("Datos guardados exitosamente en el archivo Presupuestos.json.");

        }
    }
}