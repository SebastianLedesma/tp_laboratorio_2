using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        #region Enumerados
        /// <summary>
        /// Enumerado que contiene los valores que se usarán como filtro para mostrar los elementos agregados al
        /// atributo List de la instancia de Taller.
        /// </summary>
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #endregion


        #region Atributos
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;

        #endregion


        #region "Constructores"

        /// <summary>
        /// Constructor que inicializa el atributo de tipo List al que se agregarán vehiculos.
        /// Se invocará dentro de esta clase.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }


        /// <summary>
        /// Constructor que permite instanciar un Taller.Invoca al constructor declarado previamente.
        /// </summary>
        /// <param name="espacioDisponible">Parametro que indica la cantidad de vehiculos que se pueden
        /// agregar al atributo de tipo List</param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion



        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns>Retorna una cadena de caracteres devuelta por el método estático Listar,el cual muestra el valor
        /// de los atributos del taller.</returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion


        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido.
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Retorna una cadena de caracteres con los valores de los atributos como los elementos
        /// contenidos en el atributo List según el valor del enumerado pasado como parámetro.</returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.SUV:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }

            }

            return sb.ToString();
        }
        #endregion


        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista.
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns>Retorna el taller pasado como parámetro pero modificado(si pudo agregar el vehiculo
        /// a la lista o no).</returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            bool estaIncluido = false;

            if (taller.vehiculos.Count < taller.espacioDisponible)//se evalua si hay espacio en la lista.
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                        estaIncluido = true;
                }

                if (!estaIncluido)//si el vehiculo no esta en la lista,este se agrega.
                {
                    taller.vehiculos.Add(vehiculo);
                }

            }

            return taller;
        }



        /// <summary>
        /// Quitará un elemento de la lista.
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>Retorna el objeto de tipo taller modificado(si contiene al vehiculo pasado por parámetro
        /// lo elimina.Sino el atributo de tipo List no se modifica).</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            int indice = -1;

            for (int i = 0; i < taller.vehiculos.Count; i++)
            {
                if (taller.vehiculos[i] == vehiculo)//se busca el indice donde esta el vehiculo en la lista(si es que está incluido).
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)//si se encontró el elemento en la lista,este se elimina.
            {
                taller.vehiculos.RemoveAt(indice);
            }
            return taller;
        }
        #endregion
    }
}
