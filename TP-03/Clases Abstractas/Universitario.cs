using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase abstracta que hereda de Persona.Esta clase no se puede instanciar.
    /// </summary>
    public abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor necesario para la serialización de datos.Invoca al constructor de la clase base.
        /// </summary>
        public Universitario()
            : base()
        {
        }


        /// <summary>
        /// Sobrecarga de constructor que permite crear internamente un Universitario.
        /// Invoca al constroctor de base parametrizado.
        /// </summary>
        /// <param name="legajo">Nro de legajo a asignar.</param>
        /// <param name="nombre">Nombre a asignar al universitario.</param>
        /// <param name="apellido">Apellido a asignar al universitario.</param>
        /// <param name="dni">Dni a asignar al universitario.</param>
        /// <param name="nacionalidad">Nacionalidad del universitario.</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Declaración de método abstracto que será implementado por las clases derivadas de Universitario.
        /// </summary>
        /// <returns>Deberá retornar un string.</returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Método que retorna el estado del universitario.Puede ser sobrescrito por las clases derivadas.
        /// </summary>
        /// <returns>Cadena de caracteres con los valores de los atributos del universitario.</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("LEGAJO NÚMERO: {0}", this.legajo);

            return sb.ToString();
        }
        #endregion


        #region Sobrecargas de operadores
        /// <summary>
        /// Sobrecarga del operador == que determina si dos universitarios son iguales.
        /// </summary>
        /// <param name="pg1">Universitario a comparar.</param>
        /// <param name="pg2">Universitario a comparar.</param>
        /// <returns>True si los universitarios tienen el mismo legajo o dni.</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool respuesta = false;

            if (((object)pg1) == null && ((object)pg2) == null)
            {
                respuesta = true;
            }
            else if (((object)pg1) != null && ((object)pg2) != null && (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo))
            {
                respuesta = true;
            }

            return respuesta;
        }


        /// <summary>
        /// Sobrecarga del operador != que determina si dos universitarios son distintos.Invoca a la sobrecarga de ==.
        /// </summary>
        /// <param name="pg1">Universitario a comparar.</param>
        /// <param name="pg2">Universitario a comparar.</param>
        /// <returns>True si los universitarios son distintos.</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion

        #region Sobreescritura
        /// <summary>
        /// Sobreescritura del Equals que determina si dos objetos son iguales.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns>True si el parámetro es universitario y es igual al objeto que invoca este método.</returns>
        public override bool Equals(object obj)
        {
            bool respuesta = false;

            if (obj is Universitario)
            {
                respuesta = this == (Universitario)obj;
            }

            return respuesta;
        }
        #endregion
    }
}
