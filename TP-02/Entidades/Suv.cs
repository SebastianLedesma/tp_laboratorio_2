using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Constructor
        /// <summary>
        /// Constructor que permite instanciar la clase Suv.Invoca al constructor de la clase.
        /// </summary>
        /// <param name="marca">Parametro de tipo enumerado para asignarle la marca a la camioneta.</param>
        /// <param name="chasis">Parametro de tipo string que representa el chasis de la camioneta.</param>
        /// <param name="color">Parametro de tipo enumerado para asignarle un color a la camioneta.</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }

        #endregion


        #region Propiedades
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get { return ETamanio.Grande; }
        }

        #endregion


        #region Métodos
        /// <summary>
        /// Método que sobreescribe al método de la clase base para modificar el comportamiento para que muestre
        /// los atributos de la Suv.
        /// </summary>
        /// <returns>Retorna una cadena de caracteres con los valores de los atributos de la Suv.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
