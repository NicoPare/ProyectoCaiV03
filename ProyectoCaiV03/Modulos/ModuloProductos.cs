using Newtonsoft.Json;
using ProyectoCaiV03.Archivos;
using ProyectoCaiV03.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProyectoCaiV03.Entidades;
using System.Xml;
using System.Xml.Serialization;

namespace ProyectoCaiV03.Modulos
{
    public class ModuloProductos
    {
        /*public void ProcesarVuelos()
        {
            // Leer los vuelos desde el archivo JSON            
            List<Vuelo> vuelos = VuelosArchivo.ObtenerTodas();

            // Crear una lista de productos
            List<Producto> productos = new List<Producto>();

            // Generar un código aleatorio para cada producto y deserializar los vuelos en productos
            foreach (Vuelo vuelo in vuelos)
            {
                string codigoProducto = GenerarCodigoAleatorio();
                Producto producto = new Producto(codigoProducto, vuelo, null);
                productos.Add(producto);
            }

            // Guardar los productos en un nuevo archivo JSON
            GuardarProductosEnArchivo(productos);        
        }

        public void ProcesarAlojamientos()
        {
            // Leer los alojamientos desde el archivo JSON
            List<Alojamiento> alojamientos = AlojamientosArchivo.ObtenerTodas();

            // Crear una lista de productos
            List<Producto> productos = new List<Producto>();

            // Generar un código aleatorio para cada producto y deserializar los alojamientos en productos
            foreach (Alojamiento alojamiento in alojamientos)
            {
                string codigoProducto = GenerarCodigoAleatorio();
                Producto producto = new Producto(codigoProducto, null, alojamiento);
                productos.Add(producto);
            }

            // Guardar los productos en un nuevo archivo JSON
            GuardarProductosEnArchivo(productos);
        }

        public void ProcesarProductos()
        {
            ProcesarVuelos();
            ProcesarAlojamientos();
        }*/

        public void ProcesarVuelosYAlojamientos()
        {
            // Leer los vuelos desde el archivo JSON
            List<Vuelo> vuelos = VuelosArchivo.ObtenerTodas();

            // Leer los alojamientos desde el archivo JSON
            List<Alojamiento> alojamientos = AlojamientosArchivo.ObtenerTodas();

            // Procesar los vuelos y obtener los productos correspondientes
            List<Producto> productos = new List<Producto>();

            foreach (Vuelo vuelo in vuelos)
            {
                string codigoProducto = GenerarCodigoAleatorio();
                Producto producto = new Producto(codigoProducto, vuelo, null);
                productos.Add(producto);
            }

            // Procesar los alojamientos y obtener los productos correspondientes
            foreach (Alojamiento alojamiento in alojamientos)
            {
                string codigoProducto = GenerarCodigoAleatorio();
                Producto producto = new Producto(codigoProducto, null, alojamiento);
                productos.Add(producto);
            }

            // Guardar los productos en el archivo JSON
            GuardarProductosEnArchivo(productos);
        }


        private void GuardarProductosEnArchivo(List<Producto> productos)
        {
            // Serializar los productos en formato JSON
            string productosJson = JsonConvert.SerializeObject(productos, Newtonsoft.Json.Formatting.Indented);

            // Guardar los productos en el archivo JSON
            //File.WriteAllText("Productos.json", productosJson);
            File.WriteAllText("C:\\Users\\npare\\source\\repos\\ProyectoCaiV03\\ProyectoCaiV03\\Datos\\Productos.json", productosJson);
        }

        public static string GenerarCodigoAleatorio()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

}
