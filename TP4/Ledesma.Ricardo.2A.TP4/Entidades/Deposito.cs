using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;

namespace Entidades
{
    //Clase que implementa la interface IArchivo.
    public class Deposito : IArchivo
    {
        #region Enumerado
        //Representa las herraminetas disponibles en el deposito.
        public enum EHerramientas
        {
            CintaMetrica,
            Escalera,
            Martillo,
            Taladro
        }
        #endregion

        #region Atributos
        private int stockMartillo;
        private int stockTaladro;
        private int stockEscalera;
        private int stockCinta;
        #endregion


        #region Propiedades de lectura y escrituta
        public int StockMartillo
        {
            get { return this.stockMartillo; }
            set { this.stockMartillo = value; }
        }

        public int StockTaladro
        {
            get { return this.stockTaladro; }
            set { this.stockTaladro = value; }
        }

        public int StockCinta
        {
            get { return this.stockCinta; }
            set { this.stockCinta = value; }
        }

        public int StockEscalera
        {
            get { return this.stockEscalera; }
            set { this.stockEscalera = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que instacia un objeto  de la clase.
        /// </summary>
        /// <param name="cantMartillo">Cantidad inicial de martillos en el deposito.</param>
        /// <param name="cantTaladro">Cantidad inicial de taladros en el deposito</param>
        /// <param name="cantEscalera">Cantidad inicial de escaleras en el deposito</param>
        /// <param name="cantCintas">Cantidad inicial de cintas en el deposito</param>
        public Deposito(int cantMartillo,int cantTaladro,int cantEscalera,int cantCintas)
        {
            this.stockMartillo = cantMartillo;
            this.stockTaladro = cantTaladro;
            this.stockEscalera = cantEscalera;
            this.stockCinta = cantCintas;
        }
        #endregion


        //Método que agrega una unidad a cada tipo de herramienta del depósito.
        public void AgregarStock()
        {
            this.stockCinta++;
            this.stockEscalera++;
            this.stockMartillo++;
            this.stockTaladro++;
        }


        #region Sobrecarga
        /// <summary>
        /// Sobrecarga del operador + que devuelve al depósito las herramientas del carrito.
        /// </summary>
        /// <param name="dep">Instancia del depósito.</param>
        /// <param name="carrito">Carrito donde están las herraminetas a devolver.</param>
        /// <returns>True si pudo devolver todas las herramientas.</returns>
        public static bool operator +(Deposito dep,CarritoCompra<Herramienta> carrito)
        {
            bool respuesta = false;

            if (carrito.Carrito.Count > 0)
            {
                foreach (Herramienta item in carrito.Carrito)
                {
                    if (item is CintaMetrica)
                    {
                        dep.stockCinta++;
                    }
                    else if (item is Escalera)
                    {
                        dep.stockEscalera++;
                    }
                    else if (item is Martillo)
                    {
                        dep.stockMartillo++;
                    }
                    else
                    {
                        dep.stockTaladro++;
                    }
                }
                respuesta = true;
            }

            return respuesta;
        }
        #endregion

        #region Sobreescritura
        /// <summary>
        /// Sobrerescritura del toString que retorna el estado del depósito.
        /// </summary>
        /// <returns>Cadena de caracters con la cantiad de unidades por cada herramienta.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------STOCK---------------");
            sb.AppendFormat("MARTILLO:{0}\n",this.stockMartillo);
            sb.AppendFormat("TALADRO:{0}\n",this.stockTaladro);
            sb.AppendFormat("CINTA METRICA:{0}\n",this.stockCinta);
            sb.AppendFormat("ESCALERA:{0}\n",this.stockEscalera);

            return sb.ToString();
        }
        #endregion

        #region Interface
        /// <summary>
        /// Implementación del método de la interface IArchivo que guarda en un archivo de texto la
        /// hora en la que se invoca al método.
        /// </summary>
        /// <returns>True si se pudo guradar el archivo.</returns>
        public bool GuardarInformacion()
        {
            bool respuesta;
            string path = "StockeoMercaderia.txt";
            try
            {
                using (StreamWriter escritor =new StreamWriter(path,true,Encoding.UTF8))
                {
                    escritor.WriteLine("Se pidio mercaderia a las "+DateTime.Now.Hour+":"+DateTime.Now.Minute);
                    respuesta = true;
                }
            }
            catch (Exception)
            {
                respuesta = false;
            }

            return respuesta;
        }
        #endregion
    }
}
