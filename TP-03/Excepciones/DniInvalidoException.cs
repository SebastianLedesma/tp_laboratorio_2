using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        /// <summary>
        /// Constructor que creará una exception.No especifica un mensaje.
        /// </summary>
        public DniInvalidoException()
            : base()
        {
        }

        /// <summary>
        /// Sobrecarga de constructor que recibe una exception que genera la instanciación de esta nueva.
        /// </summary>
        /// <param name="e">Exception que genera una DniInvalidoException.</param>
        public DniInvalidoException(Exception e)
            : base("DNI inválido.", e)
        {
        }

        /// <summary>
        /// Sobrecarga de constructor que recibe un mensaje personalizado.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar.</param>
        public DniInvalidoException(string mensaje)
            : base(mensaje)
        {
        }

        /// <summary>
        /// Sobrecarga de contructor que recibe un mensaje personalizado y la exception que genera una instanciación
        /// de una DniInvalido.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar.</param>
        /// <param name="e">Exception que generá una DniInvalido.</param>
        public DniInvalidoException(string mensaje, Exception e)
            : base(mensaje, e)
        {
        }
    }
}