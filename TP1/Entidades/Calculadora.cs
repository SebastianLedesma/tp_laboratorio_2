using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Metodo estatico que que permite realizar una operacion entre dos objetos de tipo Numero.
        /// </summary>
        /// <param name="numero1"></param>Primer parametro con el que se va a operar.
        /// <param name="numero2"></param>Segundo parametro con el que se va a operar.
        /// <param name="operador"></param>Cadena que representa al operador para realizar la operacion entre los objetos recibidos.
        /// <returns>Retorna el resultado de la operacion.</returns>
        public static double Operar(Numero numero1,Numero numero2,string operador)
        {
            double resultado=0;

            switch (Calculadora.ValidarOperador(char.Parse(operador)))
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
            }

            return resultado;
        }


        /// <summary>
        /// Metodo estatico que valida que el parametro recibido es un operador aritmetico(+,-,*,/)
        /// </summary>
        /// <param name="operador"></param>Parametro a evaluar.
        /// <returns>Retorna el valor del parametro convertido a string ya validado.</returns>
        private static string ValidarOperador(char operador)
        {
            string respuesta = operador.ToString();

            if (respuesta != "-" && respuesta != "*" && respuesta != "/")
            {
                respuesta = "+";
            }

            return respuesta;
        }
    }
}
