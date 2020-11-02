using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;


namespace EntidadesAbstractas
{
    [XmlInclude(typeof(Universitario))]

    //Clase que no se podrá instanciar.Será clase base.
    public abstract class Persona
    {

        #region Enumerado
        /// <summary>
        /// Enumerado que permite asignar una nacionalidad a la persona.
        /// </summary>
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion


        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion


        #region Propiedades
        //Propiedad que retorna y asigna un valor al atributo nacionalidad.
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        //Propiedad que asigna un dni a la persona si el valor recibido es de tipo string y este pasa las validaciones
        //del método estático validad dni..
        public string StringToDNI
        {
            set { this.dni = Persona.ValidadDni(this.nacionalidad, value); }
        }

        /// <summary>
        /// Propiedad que retorna y asigna un valor al atributo dni cuando el valor recibido es de tipo int y pasa las
        /// validadciones del método estatico ValidarDni.
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = Persona.ValidadDni(this.nacionalidad, value); }
        }

        /// <summary>
        /// Propiedad que retorna y asigna un valor al atributo apellido siempre que el valor recibido sea string y 
        /// pase las validadiones del método ValidadNombreApellido.
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = this.ValidadNombreApellido(value); }
        }

        /// <summary>
        /// Propiedad que retorna y asigna un valor al atributo nombre siempre que el valor recibido sea string y 
        /// pase las validadiones del método ValidadNombreApellido.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = this.ValidadNombreApellido(value); }
        }

        

        #endregion


        #region Constructores
        //Constructor que se usará para la serialización de datos.
        public Persona()
        {
        }


        /// <summary>
        /// Constructor que permitirá crear internamente una persona.
        /// </summary>
        /// <param name="nombre">Valor a asignar al atributo nombre mediante la propiedad</param>
        /// <param name="apellido">Valor a asignar al atributo apellido mediante la propiedad</param>
        /// <param name="nacionalidad">Valor a asignar al atributo nacionalidad.</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.nacionalidad = nacionalidad;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        /// <summary>
        /// Sobrecarga de constructor que permitirá crear internamnete una persona.Invoca a otro constructor.
        /// </summary>
        /// <param name="nombre">Valor a asignar al atributo nombre.</param>
        /// <param name="apellido">Valor a asignar al atributo apellido.</param>
        /// <param name="dni">Valor a asignar al atributo dni mediante la propiedad</param>
        /// <param name="nacionalidad">Valor a asignar al atributo nacionalidad.</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }


        /// <summary>
        /// Sobrecarga de constructor que permitirá crear internamnete una persona.Invoca a otro constructor.
        /// </summary>
        /// <param name="nombre">Valor a asignar al atributo nombre.</param>
        /// <param name="apellido">Valor a asignar al atributo apellido.</param>
        /// <param name="dni">Valor a asignar al atributo dni.Será validado por la propiedad.</param>
        /// <param name="nacionalidad">Valor a asignar al atributo nacionalidad.</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion


        #region Sobreescritura de métodos
        /// <summary>
        /// Sobreescritura que retornará el estado de la persona.
        /// </summary>
        /// <returns>Cadena de caracteres con el valor de los atributos de la persona.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0},{1}", this.apellido, this.nombre);
            sb.AppendLine();
            sb.AppendFormat("NACIONALIDAD: {0}", this.nacionalidad);
            sb.AppendLine();

            return sb.ToString();
        }
        #endregion


        #region Métodos
        /// <summary>
        /// Método de clase que validará el dni recibido.Verificará si está entre los rangos de valores permitidos segun
        /// la nacionalidad.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        /// <param name="dni">Número a validar.</param>
        /// <returns>El parámetro recibido ya validado.Caso contrario se lanzará la Exception ocurrida para ser tratada
        /// en otro método.</returns>
        public static int ValidadDni(ENacionalidad nacionalidad, int dni)
        {
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dni < 1 || dni > 89999999)
                    {
                        throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dni < 90000000 || dni > 99999999)
                    {
                        throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
                    }
                    break;
            }

            return dni;
        }


        /// <summary>
        /// Método de clase que validará el dni recibido en formato caracter.Verificará que la cadena cumpla con la cantidad
        /// de caracteres necesarios.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona.Se pasará como parametro en caso de que las
        /// validaciones sean correctas.</param>
        /// <param name="dni">Dni de tipo string a validar.</param>
        /// <returns>Devolverá lo que retorne el método ValidarDni.</returns>
        public static int ValidadDni(ENacionalidad nacionalidad, string dni)
        {
            int dniNumerico = 0;
            if (dni.Length > 8)
            {
                throw new DniInvalidoException("El DNI no tiene un formato válido");
            }

            try
            {
                dniNumerico = int.Parse(dni);
            }
            catch (Exception e)
            {
                throw new DniInvalidoException("El DNI no tiene un formato válido", e);
            }

            return Persona.ValidadDni(nacionalidad, dniNumerico);
        }


        /// <summary>
        /// Método de clase que validará que el parámetro recibido contenga solo caracteres latinos a-z A-Z.
        /// </summary>
        /// <param name="dato">Cadena que representa un nombre o apellido a validar.</param>
        /// <returns>Nombre o apellido validado si está todo OK, o un string vacio en caso de error</returns>
        private string ValidadNombreApellido(string dato)
        {
            string cadenaResultado;
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"[a-zA-Z]*");
            // Valido el dato
            System.Text.RegularExpressions.Match match = regex.Match(dato);

            if (match.Success)
            {
                cadenaResultado = match.Value;
            }
            else
            {
                cadenaResultado = "";
            }

            return cadenaResultado;
        }

        #endregion
    }
}

