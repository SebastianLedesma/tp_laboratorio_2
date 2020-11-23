using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    /// <summary>
    /// Clase que extiende la funcionalidad de la clase CarritoCompra.
    /// </summary>
    public static class CarritoCompraExtendido
    {

        /// <summary>
        /// Método que devolverá exclusivamente los elementos de la lista del objeto CarritoCompra.
        /// </summary>
        /// <param name="carrito">Referencia a la clase que se extiende.</param>
        /// <returns>Cadena de caracteres con el listado de los objetos contenidos en la lista del carrito.
        /// Será utilizado en un control de Windows Form.</returns>
        public static string MostrarContenidoCarrito(this CarritoCompra<Herramienta> carrito)
        {
            int contador = 0;

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DETALLE:\n");

            foreach (Herramienta item in carrito.Carrito)
            {
                contador++;
                sb.AppendFormat("{0}){1}",contador,item.ToString());
            }

            return sb.ToString();
        }
    }
}
