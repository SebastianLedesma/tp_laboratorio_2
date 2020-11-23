using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Interface que se implementará para modificar el precio de una herramienta según sus atributos.
    public interface IPrecioAjustable
    {
        float CalcularPrecio();
    }
}
