using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    /// <summary>
    /// Clase genérica que inolementa la interfaz IArchivo.
    /// </summary>
    /// <typeparam name="T">Tipo de dato que usarán los métodos de la interfaz al implementarlos.</typeparam>
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Método que permitirá guardar un un objeto de tipo T en formato Xml.
        /// </summary>
        /// <param name="archivo">Ruta donde se ubicará el archivo Xml</param>
        /// <param name="datos">Tipo de dato a guardar.</param>
        /// <returns>True si pudo guardar el parámetro de tipo T en un Xml.Caso contrario lanzará Exception.</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool respuesta = false;

            try
            {
                using (XmlTextWriter archXml = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    ser.Serialize(archXml, datos);
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }

            return respuesta;
        }


        /// <summary>
        /// Método de instancia que permitirá leer un arhivo Xml y guardar los datos en un objeto recibido por parámetro.
        /// </summary>
        /// <param name="archivo">Ruta donde se encuentra el archivo Xml a leer.</param>
        /// <param name="datos">Parámetro donde se guardará el contenido del arhicvo Xml.</param>
        /// <returns>True si pudo leer el archivo.Caso contrario lanzará Exception.</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool respuesta = false;

            try
            {
                using (XmlTextReader archXml = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    datos = (T)ser.Deserialize(archXml);
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }

            return respuesta;
        }
    }
}
