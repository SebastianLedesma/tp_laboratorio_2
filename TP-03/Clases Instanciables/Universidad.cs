using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;
using Archivos;


namespace Clases_Instanciables
{
    [XmlInclude(typeof(Universidad))]

    //Clase instanciable
    public class Universidad
    {
        #region Enumerado
        //Enumerado para agregar clases.
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        #endregion


        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion


        #region Propiedades
        /// <summary>
        /// Propiedad que retorna y asigna valor al atributo lista de profesores.
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return profesores; }
            set { profesores = value; }
        }

        /// <summary>
        /// Propiedad que retorna y asigna valor al atributo lista de Jornadas.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get { return jornada; }
            set { jornada = value; }
        }


        /// <summary>
        /// Propiedad que retorna y asigna valor al atributo lista de alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }

        /// <summary>
        /// Propiedad indexador que retorna o asigna un valor de tipo jornada.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                if (i < 0 || i > this.jornada.Count)
                {
                    return null;
                }
                else
                {
                    return this.jornada[i];
                }
            }

            set
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    this.jornada[i] = value;
                }
                else
                {
                    this.jornada.Add(value);
                }
            }
        }

        #endregion


        #region Constructor
        /// <summary>
        /// Constructor necesario para serializar datos.
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }

        #endregion

        /// <summary>
        /// Método de clase que guardará dato de tipo universidad en un archivo Xml.
        /// </summary>
        /// <param name="uni">Universidad a guardar.</param>
        /// <returns>Devolverá lo que retorne el método Guardar de la clase Xml</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> archXml = new Xml<Universidad>();

            //El archivo se guardara por defecto en TestEntidades/bin/Debug
            return archXml.Guardar("Universidad.xml", uni);
        }


        /// <summary>
        /// Método que leerá un archivo Xml.
        /// </summary>
        /// <returns>Retornará la universidad obtenida de la lectura del archivo.</returns>
        public static Universidad Leer()
        {
            Xml<Universidad> archXml = new Xml<Universidad>();
            Universidad universidad =new Universidad();

            //El archivo estará ubicado en TestEntidades/bin/Debug
            archXml.Leer("Universidad.xml", out universidad);

            return universidad;
        }


        /// <summary>
        /// Método de clase que retornaráel estado de una universidad recibida por parámetro.
        /// </summary>
        /// <param name="uni">Universidad de la cual se sabrá su estado.</param>
        /// <returns>Cadena de caracteres con los valores de los atributos de la universidad.</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");

            for (int i = 0; i < uni.jornada.Count; i++)
            {
                sb.AppendLine(uni[i].ToString());
                sb.AppendLine("<---------------------------------------------------------->");
                sb.AppendLine();
            }

            return sb.ToString();
        }


        /// <summary>
        /// Sobrecarga del operador == que determinará si el alumno está inscripto en la universidad.
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>Retorna true si el alumno ya está inscripto en la universidad(si ya se encuentra en la lista de 
        /// alumnos de la univesidad).</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool respuesta = false;

            //VERIFICAR
            foreach (Alumno item in g.alumnos)
            {
                if (item.Equals(a))
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }


        /// <summary>
        /// Sobrecarga del operador != que determina si un alumno no esta inscripto en la universidad.
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>True si el alumno no se encuentra en la lista de alumnos de la universidad.</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Sobrecarga del operador == que determina si un profesor está dando clases en la universidad.
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="i">Profesor a comparar.</param>
        /// <returns>True si el profesor está en la lista de profesores de la universidad.</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool respuesta = false;

            foreach (Profesor item in g.profesores)
            {
                if (item.Equals(i))
                {
                    respuesta = true;
                    break;
                }
            }

            return respuesta;
        }


        /// <summary>
        /// Sobrecarga  de operadore que determina si un profesor no está dando clases en la universidad.
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="i">Profesor a buscar.</param>
        /// <returns>True si el profesor no está en la lista de profesores de la univeridad.</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }


        /// <summary>
        /// Sobrecarga que retornará el primer profesor que puede dictar la clase recibida por parámetro.
        /// </summary>
        /// <param name="u">Universidad con los profesores.</param>
        /// <param name="clase">Clase que se quiere dictar.</param>
        /// <returns>Retornará el profesor que pueda dar la clase buscada.Caso contrario se lanzará Exception
        /// para ser tratada en otro método.</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor profesor = null;

            foreach (Profesor item in u.profesores)
            {
                if (item == clase)
                {
                    profesor = item;
                    break;
                }
            }

            if (profesor == null)
            {
                throw new SinProfesorException("No hay Profesor para la clase.");
            }

            return profesor;
        }


        /// <summary>
        /// Sobrecarga que retornará el primer profesor que no pueda dar la clase recibida por parámetro.
        /// </summary>
        /// <param name="u">Universidad con la lista de profesores.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>Retornará el primer profesor que entre su lista de clases no se encuentre la clase buscada.</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor profesor = null;

            foreach (Profesor item in u.profesores)
            {
                if (item != clase)
                {
                    profesor = item;
                    break;
                }
            }

            return profesor;
        }


        /// <summary>
        /// Sobrecarga que agrega un alumno a la univesidad si este no se encuentra inscripto.
        /// </summary>
        /// <param name="u">Universidad con la lista de alumnos.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>La universidad recibida como parámetro con el alumno o se lanzará una exception que será
        /// tratada en otro método.</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException("Alumno repetido.");
            }

            return u;
        }


        /// <summary>
        /// Sobrecarga que agregará una jornada con la clase si hay algún profesor que la dicte y los alumnos
        /// que la tomarán.
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="clase">Clase a agregar.</param>
        /// <returns>Si hay quien dicte la clase retornará la universidad.Caso contrario la exception
        /// ocurrida se tratará en otro método.</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profDisponible = g == clase;//puede lanzar una exception que se tratará en otro método.
            Jornada jornadaNueva;

            //VER EL NULL(SACARLO)
            if (profDisponible != null)
            {
                jornadaNueva = new Jornada(clase, profDisponible);

                foreach (Alumno item in g.alumnos)
                {
                    if (item == clase)
                    {
                        jornadaNueva += item;
                    }
                }

                g[g.jornada.Count] = jornadaNueva;
            }

            return g;
        }

        /// <summary>
        /// Sobrecarga que agregará un profesor a la universidad siempre que este no esté agregado.
        /// </summary>
        /// <param name="u">Universidad a comparar.</param>
        /// <param name="i">Profesor que se agregará a la lista.</param>
        /// <returns>La universidad con el profesor agregado,si corresponde.</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.profesores.Add(i);
            }

            return u;
        }


        /// <summary>
        /// Sobreescritura del método que retorna el estado de la universidad.
        /// </summary>
        /// <returns>Cadena de caracteres con los valores de los atributos de la universidad.</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
    }
}

