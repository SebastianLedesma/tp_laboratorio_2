using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// Se declara asbtract para que se pueda heredar de esta pero no se pueda instanciar.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Enumerados
        /// <summary>
        /// Enumerado para asignar un valor al atributo del vehiculo.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }


        /// <summary>
        /// Enumerado para mostrar el tamaño del vehiculo segun la clase.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        #endregion


        #region Atributos
        private string chasis;
        private ConsoleColor color;
        private EMarca marca;

        #endregion


        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio
        {
            get;
        }

        #endregion


        #region Constructor
        /// <summary>
        /// Constructor que permitirá crear internamente un vehiculo.Se invocará desde los constructores de las clases
        /// que hereden de la lcase Vehiculo
        /// </summary>
        /// <param name="marca">Parametro de tipo enumerado para agignar la marca al vehiculo.</param>
        /// <param name="chasis">Cadena de caracteres que representa el chasis del vehiculo.</param>
        /// <param name="color">Parametro de tipo enumerado para asignarle un color al vehiculo.</param>
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion


        #region Métodos
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Retorna una cadena de caracteres que muestra los valores de los atributos del vehiculo.
        /// Se invocará desde las clases derivadas.</returns>
        public virtual string Mostrar()//cambie a public
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", this.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", this.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", this.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion


        #region Sobrecargas
        /// <summary>
        /// Método estático que invoca al método que muestra los atributos del vehiculo.
        /// </summary>
        /// <param name="p">Vehiuclo a mostrar.</param>
        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();
        }


        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Parámetro de tipo vehiculo para comparar su chasis con el de otro.</param>
        /// <param name="v2">Parámetro de tipo vehiculo para comparar su chasis con el de otro.</param>
        /// <returns>Retorna true(son iguales) si ambos vehiculos tienen el mismo chasis o false si no hay coincidencia.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool respuesta = false;

            if (((object)v1) == null && ((object)v2) == null)
            {
                respuesta = true;
            }
            else if (((object)v1) != null && ((object)v2) != null && v1.chasis == v2.chasis)
            {
                respuesta = true;
            }
            return respuesta;
        }


        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Parametro de tipo vehiculo para comparar su chasis con el de otro.</param>
        /// <param name="v2">Parametro de tipo vehiculo para comparar su chasis con el de otro.</param>
        /// <returns>Retorna true(son distintos) si no hay coincidencia en los chasis de los vehiculos.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }

        #endregion
    }
}
