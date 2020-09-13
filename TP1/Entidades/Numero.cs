using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;


        /// <summary>
        /// Propiedad que permite setear el atributo numero,cuando se recibe una cadena de caracteres.
        /// </summary>
        public string SetNumero
        {
            set { numero = this.ValidarNumero(value);}
        }


        /// <summary>
        /// Constructor por defecto que permite crear una obejto de tipo Numero.Establece un valor por default al atributo.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }


        /// <summary>
        /// Constructor para crear un objeto de tipo Numero que recibe un paramtro para inicializar el atributo.
        /// </summary>
        /// <param name="numero"></param>Parametro de tipo double para inicializar el atributo.
        public Numero(double numero):this()
        {
            this.numero = numero;
        }


        /// <summary>
        /// Constructor de la clase que recibe un parametro para inicializar el atributo.
        /// </summary>
        /// <param name="strNumero"></param>Cadena que representa un nro para inicializar el atributo.Lo valida la propiedad SetNumero.
        public Numero(string strNumero):this()
        {
            this.SetNumero = strNumero;
        }


        /// <summary>
        /// Metodo que intenta convertir el paramtro recibido en un nro decimal.
        /// </summary>
        /// <param name="binario"></param>Cadena que representa al nro binario a convertir.
        /// <returns>Retorna una cadena que representa a un nro(si hubo conversion) o Valor incorrecto si no lo pudo convertir.</returns>
        public string BinarioDecimal(string binario)
        {
            double nroResultado = 0;
            int longitud = binario.Length;
            int j = 0;
            int potencia=0;
            string resultado = "Valor invalido"; 

            if (EsBinario(binario))
            {
                for (int i = longitud; i > 0; i--)
                {
                    potencia = (int)Math.Pow(2, j);
                    if (binario.Substring(i - 1, 1).Equals("1"))
                    {
                        nroResultado += potencia;
                    }
                    j++;
                }

                resultado = nroResultado.ToString();
            }
            else if (Double.TryParse(binario,out nroResultado))
            {
                resultado = nroResultado.ToString();
            }

            return resultado;
        }


        /// <summary>
        /// Metodo que convierte el parametro recibido a un nro binario.
        /// </summary>
        /// <param name="numero"></param>Parametro de tipo numerico que se convertira a nro binario.
        /// <returns>Retorna una cadena que representa al parametro recibido en nro binario o Valor incorrecto si no pudo hacer la conversion.</returns>
        public string DecimalBinario(double numero)
        {
            String nroBinario = "";
            double resultado = numero;
            int resto;
            String nroConvertido="";
            int longitud;

            if (numero < 0 || numero - (int)numero != 0)
            {
                nroConvertido = "Valor invalido";
            }
            else
            {
                do
                {
                    resto = (int)resultado % 2;
                    resultado = Math.Floor(resultado / 2);

                    if (resto == 0)
                    {
                        nroBinario += "0";
                    }
                    else
                    {
                        nroBinario += "1";
                    }


                    if (resultado == 1)
                    {
                        nroBinario += "1";
                        break;
                    }

                } while (resultado > 1);

                longitud = nroBinario.Length;
                for (int i = longitud; i > 0; i--)
                {
                    nroConvertido += nroBinario.Substring(i - 1, 1);
                }
                
            }

            return nroConvertido;
        }


        /// <summary>
        /// Metodo que intenta convertir una cadena en un nro binario.Si el parametro tiene formato nmerico invoca a otra funcion que hace la convercion a binario.
        /// </summary>
        /// <param name="numero"></param>Cadena que representa un nro para convertirlo en formato numerico.
        /// <returns>Retorna una cadena que representa un nro binario(si hubo conversion) o valor incorrecto si no lo pudo convertir.</returns>
        public string DecimalBinario(string numero)
        {
            double auxNumero;
            string respuesta="Valor incorrecto";
            
            if (Double.TryParse(numero,out auxNumero))
            {
                respuesta = this.DecimalBinario(Double.Parse(numero));
            }

            return respuesta;
        }


        /// <summary>
        /// Metodo que evalua si la cadena recibida como parametro tiene el formato de un nro.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna el valor de la cadena recibida pero en formato double o devuelve 0 si la cadena no representa un nro.</returns>
        private double ValidarNumero(string strNumero)
        {
            double numero;

            if (!Double.TryParse(strNumero,out numero))
            {
                numero = 0;
            }

            return numero;
        }


        /// <summary>
        /// Metodo que evalua si el parametro recibido tiene el formato de un numero binario(0 y 1)
        /// </summary>
        /// <param name="binario"></param>Cadena de caracteres a evaluar.
        /// <returns>Retorna true si la cadena representa un nro binario o false si no lo es.</returns>
        private bool EsBinario(string binario)
        {
            bool respuesta = true;
            string caracter = "";

            for (int i = 0; i < binario.Length; i++)
            {
                caracter = binario.Substring(i, 1);
                if ( caracter != "0" && caracter != "1")
                {
                    respuesta = false;
                    break;
                }
            }

            return respuesta;
        }


        /// <summary>
        /// Sobrecarga del operador -(resta) para realizar una resta entre los atributos de los parametros recibidos.
        /// </summary>
        /// <param name="nro1"></param>Primer parametro de tipo Numero a resta.
        /// <param name="nro2"></param>Segundo parametro de tipo Numero a restar.
        /// <returns>Retorna el resultado de la resta entre los atributos.</returns>
        public static double operator -(Numero nro1,Numero nro2)
        {
            return nro1.numero - nro2.numero;
        }


        /// <summary>
        /// Sobrecarga del operador *(multiplicar) para realizar una mutiplicacion entre los atributos de los objetos recibidos como parametro.
        /// </summary>
        /// <param name="nro1"></param>Primer parametro de Tipo Numero a multiplicar.
        /// <param name="nro2"></param>Segundo parametro de tipo Numero a multiplicar.
        /// <returns>Retorna el resultado de la multiplicacion entre los atributos.</returns>
        public static double operator *(Numero nro1,Numero nro2)
        {
            return nro1.numero * nro2.numero;
        }


        /// <summary>
        /// Sobrecarga del operador /(division) para que realice una division tomando los atributos de los objetos recibidos como parametro
        /// </summary>
        /// <param name="nro1"></param>Primer parametro de tipo Numero(sera el dividendo)
        /// <param name="nro2"></param>Segundo parametro de tipo Numero(sera el divisor siempre que este sea distinto de 0)
        /// <returns>Retorna el resultado de la division(si el divisor no es 0) entre los atributos.</returns>
        public static double operator /(Numero nro1,Numero nro2)
        {
            double resultado;

            if (nro2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = nro1.numero / nro2.numero;
            }

            return resultado;
        }


        /// <summary>
        /// Sobrecarga del operador + para que sume dos objetos de tipo Numero
        /// </summary>
        /// <param name="nro1"></param>Primer parametro de tipo Numero a sumar
        /// <param name="nro2"></param>Segundo parametro de tipo Numero sumar.
        /// <returns>Retorna el resultado de la suma entre los atributos.</returns>
        public static double operator +(Numero nro1,Numero nro2)
        {
            return nro1.numero + nro2.numero;
        }
    }
}
