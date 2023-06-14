using ProyectoCaiV03.Modulos;

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
            /*
            ModuloProductos moduloProductos = new ModuloProductos();
            moduloProductos.ProcesarAlojamientos();
            */
            /*
            ModuloProductos moduloProductos = new ModuloProductos();
            moduloProductos.ProcesarVuelos();*/

            /*
            ModuloProductos moduloProductos = new ModuloProductos();
            moduloProductos.ProcesarProductos();*/

            ModuloProductos moduloProductos = new ModuloProductos();

            moduloProductos.ProcesarVuelosYAlojamientos();

            Console.WriteLine("Los productos se han guardado en el archivo ProductosArchivo.json");

        }
    }
}