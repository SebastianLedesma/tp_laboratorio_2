using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    //Clase que deriva de Exception.
    public class SinStockException : Exception
    {
        //Se instanciará cuando se intente crear un objeto sin haber sotck disponible.
        public SinStockException()
            :base("No hay mercaderia suficiente.Hay que reponer mercaderia.")
        {
        }
    }
}
