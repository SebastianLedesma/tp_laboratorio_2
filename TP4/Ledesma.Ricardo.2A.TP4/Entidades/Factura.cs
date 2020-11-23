using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase que implementa interface IPrecioAjustable y IArchivo.
    /// </summary>
    [XmlInclude(typeof(Factura))]
    public class Factura : IPrecioAjustable, IArchivo
    {
        #region Enumerado
        public enum EMedioPago
        {
            Efectivo,
            Debito,
            MercadoPago
        }
        #endregion

        #region Atributos
        private int id;
        private int nroFactura;
        private float precioParcial;
        private EMedioPago medioPago;
        private float precioTotal;
        #endregion

        #region Propiedaes de lectura y escritura
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int NroFactura
        {
            get { return this.nroFactura; }
            set { this.nroFactura = value; }
        }

        public float PrecioParcial
        {
            get { return this.precioParcial; }
            set { this.precioParcial = value; }
        }

        public EMedioPago MedioPago
        {
            get { return this.medioPago; }
            set { this.medioPago = value; }
        }

        public float PrecioTotal
        {
            get { return this.precioTotal; }
            set { this.precioTotal = value; }
        }
        #endregion


        #region Constructores
        //Constructor necesario para la serializacion.
        public Factura()
        {
        }

        /// <summary>
        /// Constructor que instancia una factura.
        /// </summary>
        /// <param name="precioParcial">Precio parcial de la facutura.No es el final a cobrar.</param>
        /// <param name="medioPago">Medio de pago con el que se hace la compra.</param>
        public Factura(float precioParcial,EMedioPago medioPago)
        {
            this.nroFactura = new Random().Next(100,10000);
            this.precioParcial = precioParcial;
            this.medioPago = medioPago;
            this.precioTotal = this.CalcularPrecio();
        }


        /// <summary>
        /// Constructor necesario para crear los objetos de tipo Factura traídos de la base de datos.
        /// Recibe un atributo por cada camo de la tabla.
        /// </summary>
        public Factura(int id,int nroFactura,float precioParcial,EMedioPago medioPago,float precioTotal)
        {
            this.id = id;
            this.nroFactura = nroFactura;
            this.precioParcial = precioParcial;
            this.medioPago = medioPago;
            this.precioTotal = precioTotal;
        }
        #endregion

        #region Interfaces
        /// <summary>
        /// Método que calcula´ra el precio total de la factura.Si el medio de pago es Debito se aplica un descuento del
        /// 5 %.Si es con MercadoPago el descuento es del 10%.Sino no se aplica descuento.
        /// </summary>
        /// <returns>Precio total calculado según medio de pago.</returns>
        public float CalcularPrecio()
        {
            switch (this.medioPago)
            {
                case EMedioPago.Debito:
                    this.precioTotal = this.precioParcial - (this.precioParcial * 5 / 100);
                    break;
                case EMedioPago.MercadoPago:
                    this.precioTotal = this.precioParcial - (this.precioParcial * 10 / 100);
                    break;
                default:
                    this.precioTotal = this.precioParcial;
                    break;
            }

            return this.precioTotal;
        }

        /// <summary>
        /// Método que serializa una factura.Se guardara en la ubicación por default.
        /// </summary>
        /// <returns></returns>
        public bool GuardarInformacion()
        {
            bool respuesta;
            string path = "SerializacionFacturaEliminada.xml";//por default en la carpeta bin.

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Factura));

                    ser.Serialize(escritor, this);
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

        #region Sobreescritura
        /// <summary>
        /// Sobreescritura del método toString que retorna el estado de la factura.
        /// </summary>
        /// <returns>Cadena de caracteres con el calor de los atributos de la factura.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
            sb.AppendFormat("FACTURA NRO:{0}",this.nroFactura);
            sb.AppendLine();
            sb.AppendFormat("PRECIO PARCIAL:{0}\n",this.precioParcial);
            sb.AppendFormat("MEDIO DE PAGO:{0}\n", this.medioPago.ToString());

            if (this.precioTotal == this.precioParcial)
            {
                sb.AppendLine("NO APLICA DESCUENTO.");
            }
            else
            {
                sb.AppendLine("APLICA DESCUENTO.");
            }

            sb.AppendFormat("PRECIO TOTAL:{0}\n",this.precioTotal);
            sb.AppendLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");

            return sb.ToString();
        }
        #endregion

    }
}
