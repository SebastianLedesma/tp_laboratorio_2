using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Clase que deriva de Herramienta
    public class Escalera : Herramienta
    {
        #region Enumerados
        public enum ETamaño
        {
            Chica,
            Mediana,
            Grande
        }

        public enum EMaterial
        {
            Madera,
            Alumninio
        }
        #endregion

        #region Atributos
        private ETamaño tamaño;
        private EMaterial material;
        #endregion

        #region Propiedades de lectura y escritura
        public ETamaño Tamanio
        {
            get { return this.tamaño; }
            set { this.tamaño = value; }
        }

        public EMaterial Material
        {
            get { return this.material; }
            set { this.material = value; }
        }
        #endregion


        #region Constructores
        /// <summary>
        /// COnstructor que instancia la clase.Invoa al constructor base.
        /// </summary>
        /// <param name="distribuidor">Distribuidor de la herramineta.</param>
        /// <param name="precio">Precio de la herramienta.</param>
        /// <param name="origen">Origen de la escalera.</param>
        public Escalera(EDistribuidor distribuidor, float precio, EOrigen origen)
            :base(distribuidor,precio,origen)
        {
        }

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="distribuidor">Distribuidor de la herramineta.</param>
        /// <param name="precio">Precio de la herramienta.</param>
        /// <param name="origen">Origen de la escalera.</param>
        /// <param name="tamaño">Tamaño de la escalera de tipo enumerado.</param>
        /// <param name="material">Material de la escalera de tipo enumerado.</param>
        public Escalera(EDistribuidor distribuidor,float precio,EOrigen origen,ETamaño tamaño,EMaterial material)
            :this(distribuidor,precio,origen)
        {
            this.tamaño = tamaño;
            this.material = material;
        }
        #endregion

        #region Sobreescritura
        /// <summary>
        /// Sobreescritura del método toString que retoran el estado de la escalera.
        /// </summary>
        /// <returns>Cadena con el valor de los atribuots de la escalera.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("HERRAMIENTA:{0}   {1}", this.GetType().Name, base.ToString());
            sb.AppendLine();
            sb.AppendFormat("TAMAÑO:{0}    MATERIAL:{1}\n",this.tamaño.ToString(),this.material.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
