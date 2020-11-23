using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    //Clase que deriva de Herramineta e implementa la interfaces IPrecioAjustable.
    public class Taladro : Herramienta , IPrecioAjustable
    {
        #region Enumerados
        public enum EPesoGramos
        {
            Doscientos,
            Trescientos,
            Cuatrocientos
        }

        public enum ETiempoTrabajo
        {
            MedioHora,
            UnaHora,
            HorayMedia
        }
        #endregion

        #region Atributos
        public EPesoGramos peso;
        public ETiempoTrabajo tiempoTrabajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que isntancia la clase.Invoca al constructor base.
        /// </summary>
        /// <param name="distribuidor">Distribuidor del taladro.</param>
        /// <param name="precio">Precio del taladro.</param>
        /// <param name="origen">Origen del taladro.</param>
        public Taladro(EDistribuidor distribuidor, float precio, EOrigen origen)
            :base(distribuidor,precio,origen)
        {
            base.precio = this.CalcularPrecio();
        }

        /// <summary>
        /// Sobrecarga del constuctor de instancia.
        /// </summary>
        /// <param name="distribuidor">Distribuidor del taladro.</param>
        /// <param name="precio">Precio del taladro.</param>
        /// <param name="origen">Origen del taladro.</param>
        /// <param name="peso">Peso del taladro en gms.</param>
        /// <param name="tiempo">Tiempo que se puede usar el taladro.</param>
        public Taladro(EDistribuidor distribuidor,float precio,EOrigen origen,EPesoGramos peso,ETiempoTrabajo tiempo)
            :this(distribuidor,precio,origen)
        {
            this.peso = peso;
            this.tiempoTrabajo = tiempo;
        }
        #endregion


        #region Soreescritura
        /// <summary>
        /// Sobreescritura que retorna el estado del taladro.
        /// </summary>
        /// <returns>Cadena con los calores de los atrivutos del taladro.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("HERRAMIENTA:{0}  {1}", this.GetType().Name,base.ToString());
            sb.AppendLine();
            sb.AppendFormat("PESO:{0} GM    TIEMPO TRABAJO:{1}\n", this.peso.ToString(),this.tiempoTrabajo.ToString());

            return sb.ToString();
        }
        #endregion

        #region Interface
        /// <summary>
        /// Implementación del metodo de la intereface IPrecioAjustable.Si el taladro es de origen nacional se aplica un
        /// 15 % de descuento.
        /// </summary>
        /// <returns>Precio final del taladro.</returns>
        public float CalcularPrecio()
        {
            if (this.origen.ToString().Equals(EOrigen.Argentina.ToString()))
            {
                base.precio -= (base.precio * 15 / 100);
            }

            return base.precio;
        }
        #endregion
    }
}
