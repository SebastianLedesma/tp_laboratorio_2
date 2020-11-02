using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using System.Xml.Serialization;


namespace Clases_Instanciables
{
    [XmlInclude(typeof(Profesor))]

    //CLase instanciable que hereda de Universitario.No se podrá heredar de esta clase.
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion


        #region Constructores
        //Constructor de clase que inicaliza atributo de clase random.
        static Profesor()
        {
            Profesor.random = new Random();
        }

        /// <summary>
        /// Constructor necesario para la serialización de datos.Invoca al constructor base.
        /// </summary>
        public Profesor()
           : base()
        {
        }

        /// <summary>
        /// Sobrecarga de constructor que instancia un profesor.Invoca constructor base.
        /// </summary>
        /// <param name="id">Id a asignar en el atributo legajo como universitario.</param>
        /// <param name="nombre">Nombre del profesor.</param>
        /// <param name="apellido">Apellido del profesor.</param>
        /// <param name="dni">Dni del profesor.</param>
        /// <param name="nacionalidad">Nacionalidad del profesor.</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this.randomClases();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método que asigna de forma aleatoria las 2 clases que el profesor puede dictar.
        /// </summary>
        private void randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 4));
            }
        }
        #endregion

        #region Sobreescritura de Métodos
        /// <summary>
        /// Sobreescritura del métodos virtual que retorna el estado del profesor.
        /// </summary>
        /// <returns>Cadena de caracteres con los valores de los atributos del profesor.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }


        /// <summary>
        /// Sobreescritura del método ToString que retorna el estado del profesor.
        /// </summary>
        /// <returns>Retorna lo que devuelve el método de instancia MostrarDatos.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Sobreescritura del método abstracto que retorna las clases que dicta el profesor.
        /// </summary>
        /// <returns>Cadena de caracteres con los valores del atributo clasesDelDia.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA:");

            if (this.clasesDelDia != null)
            {
                foreach (Universidad.EClases item in this.clasesDelDia)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString();
        }
        #endregion


        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador == que determina si un profesor dicta una clase determinada.
        /// </summary>
        /// <param name="i">Profesor que contiene la lista de clases.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>True si la clase recibida como parámetro es dictada por el profesor.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool respuesta = false;

            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    respuesta = true;
                    break;
                }
            }

            return respuesta;
        }

        /// <summary>
        /// Sobrecarga que determina si un profesor no dicta determinada clase.
        /// </summary>
        /// <param name="i">Profesor a comparar.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>True si el profesor no dicata la clase recibida como parámetro.</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion
    }
}
