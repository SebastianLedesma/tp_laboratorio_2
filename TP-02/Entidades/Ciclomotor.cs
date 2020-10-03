using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructores
        /// <summary>
        /// Constructor que permite instanciar la clase Ciclomotor.Invoca al constructor de la clase base.
        /// </summary>
        /// <param name="marca">Parametro de tipo enumerado para asignarle la marca a la moto.</param>
        /// <param name="chasis">Parametro de tipo string que representa el chasis de la moto.</param>
        /// <param name="color">Parametro de tipo enumerado para asignarle un color a la moto.</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis, color)
        {
        }

        #endregion


        #region Propiedades
        /// <summary>
        /// Las motos son chicas.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get{ return ETamanio.Chico; }
        }
        #endregion


        #region Métodos
        /// <summary>
        /// Método sobreescrito de la clase base que muestra los atributos del vehiculo.Se modifica el comportamiento
        /// para que muestre los atributos de la moto.
        /// </summary>
        /// <returns>Retorna una cadena de caracteres con los valores de los atributos de la moto.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
