using Newtonsoft.Json;
using ProyectoCaiV03.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoCaiV03.Archivos
{
    internal static class PersonasArchivo
    {
        static List<Persona> todos;

        static PersonasArchivo()
        {
            //si existe el archivo...
            if (File.Exists("Persona.json"))
            {
                //lee TODO el contenido del archivo.
                string contenidoDelArchivo = File.ReadAllText("Persona.json");

                //esta linea convierte el texto
                //de vuelta a objetos de tipo PersonaEnt;

                todos = JsonConvert.DeserializeObject<List<Persona>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Persona>();
            }
        }


    }
}
