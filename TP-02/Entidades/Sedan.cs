using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Enumerados
        /// <summary>
        /// Enumerado para asginar la cantidad de puertas de un objeto de tipo Sedan.
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }

        #endregion


        #region Atributos
        private ETipo tipo;
        #endregion


        #region Constructores
        /// <summary>
        /// Constructor que crea una instancia de tipo Sedan y asigna un valor por defecto al atributo tipo.
        /// Invoca al constructor de la clase base.
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Enumerado para asignar una marca al Sedan.</param>
        /// <param name="chasis">Cadena de caracteres que representa un valor para el chasis del Sedan.</param>
        /// <param name="color">Enumerado para asignarle un color al Sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
            tipo = ETipo.CuatroPuertas;
        }



        /// <summary>
        /// Sobrecarga de constructor para crear un Sedan.Invoca al constructor de esta misma declarado anteriormente.
        /// </summary>
        /// <param name="marca">Enumerado para asignar una marca al Sedan.</param>
        /// <param name="chasis">Cadena de caracteres que representa un valor para el chasis del Sedan.</param>
        /// <param name="color">Enumerado para asignarle un color al Sedan.</param>
        /// <param name="tipo">Enumerado para asignarle un valor atributo tipo del Sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        #endregion


        #region Propiedades
        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get{ return ETamanio.Mediano; }
        }

        #endregion


        #region Métodos
        /// <summary>
        /// Método sobreescrito de la clase base que modifica el comportamiento para mostrar
        /// todos los atributos del Sedan.
        /// </summary>
        /// <returns>Retorna una cadena de caracteres con los valores de los atributos del Sedan.</returns>
        public override sealed string Mostrar()//quito el sealed y lo dejo public
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());//cambio el this por el base
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);//cambio el appendLine por el Format
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
