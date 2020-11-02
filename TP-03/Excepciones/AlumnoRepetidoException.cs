using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    //Clase que se instanciará cuando se repita un alumno.
    public class AlumnoRepetidoException : Exception
    {
        /// <summary>
        /// Constructor que creará una exception con un mensaje por defaul.
        /// </summary>
        public AlumnoRepetidoException()
            : base("Ocurrió un problema con el alumno.")
        {
        }

        /// <summary>
        /// Sobrecarga de constructor que creará una exception y resivirá el mensaje a mostrar como parámetro.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar.</param>
        public AlumnoRepetidoException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
