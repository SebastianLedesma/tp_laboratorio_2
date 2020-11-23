using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
   //Clase base
    public class Herramienta
    {
        #region Enumerados
        public enum EOrigen
        {
            Argentina,
            Brasil,
            Paraguay
        }

        public enum EDistribuidor
        {
            HerramientasArgentinas,
            HerramientasCongreso,
            ElReyDeLasHerramientas
        }
        #endregion

        #region Atributos
        protected EDistribuidor distribuidor;
        protected float precio;
        protected EOrigen origen;
        #endregion

        #region Porpiedades de lectura y escritura
        public EDistribuidor Distribuidor
        {
            get { return this.distribuidor; }
            set { this.distribuidor = value; }
        }

        public EOrigen PaisOrigen
        {
            get { return this.origen; }
            set { this.origen = value; }
        }

        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que sera invocado por las clases derivadas de esta.
        /// </summary>
        /// <param name="distribuidor">Distribuidor de la herramienta.</param>
        /// <param name="precio">Precio de la herramineta.</param>
        /// <param name="origen">Origen de la herramienta.</param>
        public Herramienta(EDistribuidor distribuidor,float precio,EOrigen origen)
        {
            this.distribuidor = distribuidor;
            this.precio = precio;
            this.origen = origen;
        }
        #endregion

        #region Sobreescritura
        /// <summary>
        /// Sobreescritura que retorna el estado de la herramienta.Será utilizado por las clases derivadas.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DISTRIBUYE:{0}    PRECIO:{1}   ORIGEN:{2}",this.distribuidor.ToString(),this.precio,this.origen.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
