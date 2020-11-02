using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excepciones
{
    //Clase que se instanciará cuando surja un problema con el trabajo de archivos.
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Constructor que creará una exception con un mensaje por defecto.
        /// </summary>
        public ArchivosException()
            : base("Problemas con el archivo.")
        {
        }

        /// <summary>
        /// Constructor que creará una exception con un mensaje personalizado.
        /// </summary>
        /// <param name="innerException">Exception previa que generará esta una exception de este tipo.</param>
        public ArchivosException(Exception innerException)//se lanzara en el metodo Guardar.
            : base("No se pudo acceder al archivo.", innerException)
        {
        }
    }
}
