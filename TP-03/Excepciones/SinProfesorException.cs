using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {
        /// <summary>
        /// Constructor que instanciará esta clase con un mensaje por default.
        /// </summary>
        public SinProfesorException()
            : base("Ocurrió un problema con el profesor.")
        {
        }


        /// <summary>
        /// Sobrecarga de constuctor que instanciará esta clase con un mensaje personalizado.
        /// </summary>
        /// <param name="mensaje"></param>
        public SinProfesorException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
