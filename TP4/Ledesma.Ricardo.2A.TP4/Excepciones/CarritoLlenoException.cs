using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    //Clase que instanciará una nueva Exception.
    public class CarritoLlenoException : Exception
    {
        //Constructor de la clase que deriva de Exception.Se instanciará cuando se intente agregar un objeto al carrito y
        // se supere la capacidad del mismo.
        public CarritoLlenoException(string mensaje):base(mensaje)
        {
        }
    }
}
