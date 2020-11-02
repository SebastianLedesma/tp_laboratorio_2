using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Constructor que instanciará está clase con un mensaje de error por default.
        /// </summary>
        public NacionalidadInvalidaException()
            : this("Nacionalidad invalida.")
        {
        }

        /// <summary>
        /// Sobrecarga de constructor que instanciará esta clase un mensaje personalizado.
        /// </summary>
        /// <param name="mensaje">Mensaje personalizado.</param>
        public NacionalidadInvalidaException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
