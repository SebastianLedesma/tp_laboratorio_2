using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Clase dericada de Herramienta.
    public class Martillo : Herramienta
    {
        #region Enumerados
        public enum ETipoMartillo
        {
            Carpintero,
            Chapista,
            Maza
        }

        public enum ETipoDeMango
        {
            Madera,
            Metal,
            Plastico
        }
        #endregion

        #region Atributos
        private ETipoMartillo tipo;
        private ETipoDeMango tipoMango;
        #endregion

        #region Propieedades de lectura y escritura.
        public ETipoMartillo TipoMartillo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public ETipoDeMango TipoDeMango
        {
            get { return this.tipoMango; }
            set { this.tipoMango = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que instancia la clase.Invoca al constructor base.
        /// </summary>
        /// <param name="distribuidor">Distribuidor del martillo.</param>
        /// <param name="precio">Precio del martillo</param>
        /// <param name="origen">Origen del martillo.</param>
        public Martillo(EDistribuidor distribuidor, float precio, EOrigen origen)
            :base(distribuidor,precio,origen)
        {
        }

        /// <summary>
        /// Sobrecarga del constructor de instacia.
        /// </summary>
        /// <param name="distribuidor">Distribuidor del martillo.</param>
        /// <param name="precio">Precio del martillo</param>
        /// <param name="origen">Origen del martillo.</param>
        /// <param name="tipo">Tipo de martillo.</param>
        /// <param name="tipoMango">Tipo de mango.</param>
        public Martillo(EDistribuidor distribuidor,float precio,EOrigen origen,ETipoMartillo tipo,ETipoDeMango tipoMango)
            :this(distribuidor,precio,origen)
        {
            this.tipo = tipo;
            this.tipoMango = tipoMango;
        }
        #endregion

        #region Sobreescritura
        /// <summary>
        /// Sobreescritura del toString que retorna el estado del martillo.
        /// </summary>
        /// <returns>Cadena de caracteres con los valores de los atributos del martillo.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("HERRAMIENTA:{0}   {1}", this.GetType().Name, base.ToString());
            sb.AppendLine();
            sb.AppendFormat("TIPO:{0}   TIPO DE MANGO:{1}\n", this.tipo.ToString(),this.tipoMango.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
