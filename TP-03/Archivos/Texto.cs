using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    /// <summary>
    /// Clase que implementa la interface IArchivo.Debe implementar los métodos declarados en la interface.
    /// </summary>
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Método que guardará un dato recibido como parámetro en un archivo de texto.
        /// </summary>
        /// <param name="archivo">Ruta donde se guardará el archivo de texto.</param>
        /// <param name="datos">Cadena de carateres que se guardarán en el archivo de texto.</param>
        /// <returns>True si pudo guardar el parámetro.Caso contrario la exception ocurrida será lanzada para ser tratada
        /// en otro método.</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool respuesta = false;

            try
            {
                using (StreamWriter archTexto = new StreamWriter(archivo,true))
                {
                    archTexto.WriteLine(datos);
                    respuesta = true;
                }

            }
            catch (ArchivosException ex)
            {
                throw ex;
            }

            return respuesta;
        }


        /// <summary>
        /// Método que permitirá leer un archivo en forma de texto y guardarlo en un parámetro recibido.
        /// </summary>
        /// <param name="archivo">Ruta donde se encuetra el archivo a leer.</param>
        /// <param name="datos">Parámetro donde se guardarán los datos leidos.</param>
        /// <returns>True si pudo leer los datos correctamente.Caso contrario la exception ocurrida será lanzada para
        /// ser tratada en otro método.</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool respuesta = false;

            try
            {
                using (StreamReader archTexto = new StreamReader(archivo, Encoding.UTF8))
                {
                    datos = archTexto.ReadToEnd();
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