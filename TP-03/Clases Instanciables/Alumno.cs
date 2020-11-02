using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using System.Xml.Serialization;


namespace Clases_Instanciables
{
    [XmlInclude(typeof(Alumno))]

    //Clase instanciable que hereda de Universitario.No se podrá heredar de esta clase.
    public sealed class Alumno : Universitario
    {
        #region Enumerado
        //Enumerado que contiene valores para asignar uno al atributo estado de cuenta.
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion


        #region Atributos
        private EEstadoCuenta estadoCuenta;
        private Universidad.EClases claseQueToma;
        #endregion


        #region Constructores
        /// <summary>
        /// Constructor necesario para serialización de datos.Invoca al constructor base.
        /// </summary>
        public Alumno()
            : base()
        {
        }


        /// <summary>
        /// Sobrecarga de constructor que permite instanciar un alumno.
        /// </summary>
        /// <param name="id">Id para asignar al legajo del alumno/universitario.</param>
        /// <param name="nombre">Nombre para asignar al alumno.</param>
        /// <param name="apellido">Apellido para asignar al alumno.</param>
        /// <param name="dni">Dni para asignar al alumno.</param>
        /// <param name="nacionalidad">Nacionalidad para asignar al alumno.</param>
        /// <param name="claseQueToma">Clase que toma en la universidad.</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }


        /// <summary>
        /// Sobrecarga de constructor que permite instanciar un alumno.
        /// </summary>
        /// <param name="id">Id para asignar al legajo del alumno/universitario.</param>
        /// <param name="nombre">Nombre para asignar al alumno.</param>
        /// <param name="apellido">Apellido para asignar al alumno.</param>
        /// <param name="dni">Dni para asignar al alumno.</param>
        /// <param name="nacionalidad">Nacionalidad para asignar al alumno.</param>
        /// <param name="claseQueToma">Clase que toma en la universidad.</param>
        /// <param name="estadoCuenta">Estado de cuenta del alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion


        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador == que determina si el alumno toma la clase y su estado no es Deudor.
        /// </summary>
        /// <param name="a">Alumno a comparar.</param>
        /// <param name="clase">Clase que se va a comparar.</param>
        /// <returns>True si el alumno toma la clase recibida como parametro y su estado no es Deudor.</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool respuesta = false;

            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                respuesta = true;
            }

            return respuesta;
        }

        /// <summary>
        /// Sobrecarga del operador != que determina si el alumno toma determinada clase.
        /// </summary>
        /// <param name="a">Alumno a comparar.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>True si el alumno no toma la clase recbibida como parámetro.</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma != clase;
        }

        #endregion


        #region Sobreescritura
        /// <summary>
        /// Sobreescritura del método virtual que retornará el estado del alumno.
        /// </summary>
        /// <returns>Cadena de caracteres con los valores de los atributos del alumno.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine();
            sb.AppendFormat("ESTADO DE CUENTA: ");

            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    sb.AppendLine("Cuota al día");
                    break;
                case EEstadoCuenta.Deudor:
                    sb.AppendLine("Cuotas impagas");
                    break;
                case EEstadoCuenta.Becado:
                    sb.AppendLine("Alumno becado");
                    break;
            }
            sb.AppendLine();
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescritura del método abstract que retornará la clase que toma el alumno.
        /// </summary>
        /// <returns>Cadena de caracteres con el valor de atributo claseQueToma.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("TOMA CLASES DE {0}", this.claseQueToma.ToString());

            return sb.ToString();
        }


        /// <summary>
        /// Sobreescritura del método que retornará el estado del alumno.
        /// </summary>
        /// <returns>Valor devuelto por el método de instancia MostrarDatos.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion
    }
}
