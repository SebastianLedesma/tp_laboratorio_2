using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Interface que se implemtará para guardar información.Las clases que la implementen determinarán de que manera se 
    //guardará.
    public interface IArchivo
    {
        bool GuardarInformacion();
    }
}
