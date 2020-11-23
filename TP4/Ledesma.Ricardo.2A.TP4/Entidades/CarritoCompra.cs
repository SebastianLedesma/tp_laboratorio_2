using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace Entidades
{
    //Clase generica que permitirá agregar objetos de la clase herramientas y derivadas.
    public class CarritoCompra<T>  where T : Herramienta 
    {
        #region Atributos
        private List<T> carrito;
        private int capacidadCarrito;
        private float precioCarrito;
        #endregion

        #region Prodiedades de solo lectura
        public List<T> Carrito
        {
            get { return this.carrito; }
        }

        public int CapacidadCarrito
        {
            get { return this.capacidadCarrito; }
        }


        //Propiedad que recorre la lista y acumula los precios en el atributo.
        public float PrecioCarro
        {
            get {
                this.precioCarrito = 0;
                if (this.carrito.Count >  0)
                {
                    foreach (T item in this.carrito)
                    {
                        this.precioCarrito += item.Precio;
                    }
                }

                return this.precioCarrito;
            }
        }
        #endregion


        #region Constructores
        /// <summary>
        /// Constructor que inicializa la lista y el valor del atributo precioCarrito.
        /// </summary>
        public CarritoCompra()
        {
            this.carrito = new List<T>();
            this.precioCarrito = 0;
        }


        /// <summary>
        /// Constructor parametrizado que inicializa el atributo para establecer un mazimo de productos a agregar a la lista.
        /// </summary>
        /// <param name="capacidad">Capacidad máxima de elementos que se guardaran en la lista.</param>
        public CarritoCompra(int capacidad):this()
        {
            this.capacidadCarrito = capacidad;
        }

        #endregion


        #region Sobreescritura

        /// <summary>
        /// Método que muestra el estado del objeto CarritoCompra.
        /// </summary>
        /// <returns>Cadena de caracteres que muestra la capacidad del carrito,los elementos de la lista y el precio acumulado.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad del carrito:{0}",this.capacidadCarrito);
            sb.AppendLine();
            sb.AppendFormat("*******************PRODUCTOS********************");
            sb.AppendLine();

            foreach (T item in this.carrito)
            {
                sb.AppendLine(item.ToString());
                this.precioCarrito += item.Precio;
                sb.AppendLine();
            }
            sb.AppendLine("*************************************************");
            sb.AppendFormat("PRECIO CARRITO:${0}\n",this.PrecioCarro);
            sb.AppendLine("*************************************************");
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion


        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga que permite agregar elementos al carrito.
        /// </summary>
        /// <param name="c">Carrito que contiene la lista para agregar el elemento.</param>
        /// <param name="u">Elemento a agregar a la lista.</param>
        /// <returns>Retornará el carrito con el producto agregado o se lanzará una exception.</returns>
        public static CarritoCompra<T> operator +(CarritoCompra<T> c,T u)
        {
            if (c.carrito.Count < c.capacidadCarrito)
            {
                c.carrito.Add(u);
            }
            else
            {
                throw new CarritoLlenoException("No se pueden agregar mas productos al carrito.");
            }

            return c;
        }
        #endregion
    }
}
