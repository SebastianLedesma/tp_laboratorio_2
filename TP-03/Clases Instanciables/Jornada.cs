using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using System.Xml.Serialization;


namespace Clases_Instanciables
{
    [XmlInclude(typeof(Jornada))]

    //Clase instanciable.
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura del atributo alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo clase.
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo instructor.
        /// </summary>
        public Profesor Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }
        #endregion


        #region Constructores
        /// <summary>
        /// Constructor necesario para la serialización de datos.Inicializa la lista de alumnos.
        /// </summary>
        public Jornada()
        {
            this.alumnos = new List<Alumno>();
        }


        /// <summary>
        /// Sobrecarga de constructor que instancia una jorndad.
        /// </summary>
        /// <param name="clase">Clase que se dictará en la jornada.</param>
        /// <param name="instructor">Profesor que dictará la clase.</param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador == que determina si un alumno participa de la clase.
        /// </summary>
        /// <param name="j">Jornada con la lista de alumnos a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>True si el alumno ya está en la lista de alumnos de la jornadad.</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool estaIncluido = false;

            foreach (Alumno item in j.alumnos)
            {
                if (item.Equals(a))
                {
                    estaIncluido = true;
                    break;
                }
            }

            return estaIncluido;
        }

        /// <summary>
        /// Sobrecarga del operador != que determina si un alumno no esta en la lista de alumnos de la jornada.
        /// </summary>
        /// <param name="j">Jornada con la lista de alumnos a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>True si el alumno no está en la lista.</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }


        /// <summary>
        /// Sobrecarga del operador + que agrega un alumno a la lista de alumnos de 
        /// la jornada(si es que este no esta en la lista).
        /// </summary>
        /// <param name="j">Jornada con la lista de alumnos a recorrer.</param>
        /// <param name="a">Alumno a agregar.</param>
        /// <returns>La jornada recibida con el alumno agregado o no.</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Sobreescritura de método que retorna el estado de la jornada.
        /// </summary>
        /// <returns>Cadena de caracteres con el valor de los atributos de la jornada.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE {0} POR {1}", this.clase.ToString(), this.instructor.ToString());
            sb.AppendFormat("ALUMNOS:");
            sb.AppendLine();

            foreach (Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }


        /// <summary>
        /// Método de clase que guardará una jornadad en un achivo de texto.
        /// </summary>
        /// <param name="j">Objeto a guardar.</param>
        /// <returns>Lo que retorne el método Guardar de la clase Texto.</returns>
        public static bool Guardar(Jornada j)
        {
            Texto archTexto = new Texto();

            //El archivo se guardará por defecto en TestEntidades/bin/Debug
            return archTexto.Guardar("Jornada.txt", j.ToString());
        }


        /// <summary>
        /// Método de clase que leerá un archivo de texto y retornará los datos de las jornadas
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            Texto archTexto = new Texto();
            string datos = "";

            //El archivo estará ubucado en TestEntidades/bin/Debug
            archTexto.Leer("Jornada.txt", out datos);

            return datos;
        }

        #endregion
    }
}

