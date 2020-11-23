using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Clase derivada de Herramienta
    public class CintaMetrica : Herramienta
    {
        #region Enumedaros de la clase
        //Largo de la cinta métrica.
        public enum ELargoCintaMts
        {
            Dos,
            Tres,
            Cuatro
        }

        //Tipo de material de la cinta.
        public enum EMaterial
        {
            Plastico,
            AceroInoxidable,
            FibraVidrio
        }
        #endregion

        #region Atributos
        private ELargoCintaMts largoCinta;
        private EMaterial material;
        #endregion


        #region Propiedades de lectura y escritura
        public ELargoCintaMts LargoCinta
        {
            get { return this.largoCinta; }
            set { this.largoCinta = value; }
        }

        public EMaterial Material
        {
            get { return this.material; }
            set { this.material = value; }
        }
        #endregion


        #region Constructores
        /// <summary>
        /// Constructor que oermite instanciar una cinta métrica.Constructor que será usado en los formularios.
        /// </summary>
        /// <param name="distribuidor">Distribuidor del producto.</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="origen">Origen del producto.</param>
        public CintaMetrica(EDistribuidor distribuidor, float precio, EOrigen origen)
            :base(distribuidor,precio,origen)
        {
        }

        /// <summary>
        /// Constructor que permite instanciar una cinta métrica.Se usa en el test consola y en el form.
        /// </summary>
        /// <param name="distribuidor">Distribuidor del producto.</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="origen">Origen del producto.</param>
        /// <param name="largoCinta">Longitud de la cinta.</param>
        /// <param name="material">Material de la cinta.</param>
        public CintaMetrica(EDistribuidor distribuidor,float precio,EOrigen origen,ELargoCintaMts largoCinta,EMaterial material)
            :this(distribuidor,precio,origen)
        {
            this.largoCinta = largoCinta;
            this.material = material;
        }
        #endregion

        #region Sobreescritura
        /// <summary>
        /// Sobreescritua del toString que retorna el estado de la cinta.
        /// </summary>
        /// <returns>Cadena de caracteres con los valoresde los atributos de la cinta.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("HERRAMIENTA:{0}   {1}\n",this.GetType().Name, base.ToString());
            sb.AppendFormat("MTS DE CINTA:{0}   MATERIAL:{1}\n",this.largoCinta.ToString(),this.material.ToString());

            return sb.ToString();

        }
        #endregion
    }
}
