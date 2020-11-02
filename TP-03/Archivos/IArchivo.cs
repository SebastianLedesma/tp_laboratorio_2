using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    /// <summary>
    /// Interface que se implementará para guardar y leer datos.
    /// </summary>
    /// <typeparam name="T">El tipo de dato a leer y guardar será indicado en las clases que implementen esta interface.</typeparam>
    public interface IArchivo<T>
    { 
        bool Guardar(string archivo, T datos);

        bool Leer(string archivo, out T datos);
    }
}
