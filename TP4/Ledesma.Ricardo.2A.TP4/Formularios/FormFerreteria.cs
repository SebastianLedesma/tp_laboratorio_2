using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using System.Threading;

namespace Formularios
{
    //Formulario principal
    public partial class FormFerreteria : Form
    {
        #region Atributos
        Deposito deposito = new Deposito(2,2,2,2);
        private CarritoCompra<Herramienta> carrito;
        FormStock formStock;
        Thread hiloStockeo;
        #endregion


        public FormFerreteria()
        {
            InitializeComponent();
            this.carrito = new CarritoCompra<Herramienta>(4);//se inicializa en carrito para poder agregar herramientas.
        }


        //Se intentará vender lo detallado en el richtextbox.
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (this.carrito.Carrito.Count > 0)//si hay herramientas en el carrito se hace la venta.
            {
                //Se crea un factura de la compra.
                Factura factura = new Factura(this.carrito.PrecioCarro,(Factura.EMedioPago)this.cmbMedioDePago.SelectedItem);
                MessageBox.Show(factura.ToString(), "Venta exitosa!!!");

                if (!ConectorBaseDatos.InsertarFactura(factura))//se intenta guardar la factura en la base de datos.
                {
                    MessageBox.Show("No se guardo el dato.");   
                }
                
                this.carrito.Carrito.Clear();//se limpia el carrito pero no se elimina la instancia.
                this.LimpiarComponentes();// se limpian los componentes.
            }
        }


        //Si se cancela una venta.
        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (this.deposito + this.carrito)//la sobrecarga devuelve las herramientas al depósito.
            {
                this.carrito.Carrito.Clear();//se limpia el carrito pero no se elimina la instancia.
            }
            this.LimpiarComponentes();//se limpia los componentes.
        }


        //Se ingresará mercaderia al deposito MEDIANTE HILOS.
        private void btnPedirMercaderia_Click(object sender, EventArgs e)
        {
            this.hiloStockeo = new Thread(this.StockearMercaderia);//se intancia un hilo
            this.btnPedirMercaderia.Enabled = false;
            this.btnDetenerStockeo.Enabled = true;

            deposito.GuardarInformacion();//Se dejará un registro de la hora en la que se pidió reposición de mercadería.
            //Se guardara en un txt en la carpeta por default.

            this.formStock = new FormStock(this.deposito);//Se instancia un form donde se mostrará la carfa del depósito.
            this.formStock.Show();
            
            //uso de hilos.
            try
            {
                if (!this.hiloStockeo.IsAlive)
                {
                    this.hiloStockeo.Start();
                }
                else
                {
                    this.hiloStockeo.Abort();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al usar el hilo.");
            }
        }


        //Se detendrá la reposición de herramientas para la venta.
        private void btnDetenerStockeo_Click(object sender, EventArgs e)
        {
            this.btnDetenerStockeo.Enabled = false;
            this.btnPedirMercaderia.Enabled = true;

            //uso de hilos.
            try
            {
                this.hiloStockeo.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        //Se instanciará un form donde se consultará a la base de datos los registros de las facturas emitidas.
        private void btnVentasGeneradas_Click(object sender, EventArgs e)
        {
            FormFacturas formularioFact = new FormFacturas();

            formularioFact.ShowDialog();
        }


        //Segun el indice seleccionado del combo de herramientas.
        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormHerramientas herramienta;

            try
            {
                this.VerificarStockDisponible(this.cmbProductos.SelectedIndex);//puede lanzar SinStockException

                herramienta = new FormHerramientas();//se crea el formulario geenral para la instanciación de la herramienta.

                if (herramienta.ShowDialog() == DialogResult.OK)
                {
                    //Se invoca al método que permitirá completar el pedido de la herramienta.
                    this.CompletarAtributoHerramienta(herramienta.PropHerramienta);
                }
            }
            catch (SinStockException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            catch (CarritoLlenoException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }


        //Carga previa de datos para el funcionaminento de la ferretería.
        private void FormFerreteria_Load(object sender, EventArgs e)
        {
            foreach (Factura.EMedioPago item in Enum.GetValues(typeof(Factura.EMedioPago)))
            {
                this.cmbMedioDePago.Items.Add(item);
            }
            this.cmbMedioDePago.SelectedIndex = 0;
            this.txtSockCinta.Text = deposito.StockCinta.ToString();
            this.txtStockEscalera.Text = deposito.StockEscalera.ToString();
            this.txtStockMartillo.Text = deposito.StockMartillo.ToString();
            this.txtStockTaladro.Text = deposito.StockTaladro.ToString();
        }


        //A partir del indice del combo de herramientas seleccionado se instanciará el formulario para la creación de la
        //herramienta específica.
        private void CompletarAtributoHerramienta(Herramienta herramienta)
        {
            switch (this.cmbProductos.SelectedIndex)
            {
                case 0:
                    FormCinta cintaform = new FormCinta(herramienta);//para una cinta.
                    if (cintaform.ShowDialog() == DialogResult.OK)
                    {
                        this.carrito += cintaform.CintaForm;//se agrega al carrito
                        this.deposito.StockCinta--;//se quita una unidad del depósito.
                    }
                    break;
                case 1:
                    FormEscalera escalera = new FormEscalera(herramienta);//para una escalera
                    if (escalera.ShowDialog() == DialogResult.OK)
                    {
                        this.carrito += escalera.EscaleraForm;
                        this.deposito.StockEscalera--;//se quita una unidad del depósito.
                    }
                    break;
                case 2:
                    FormMartillo martillo = new FormMartillo(herramienta);//para un martillo.
                    if (martillo.ShowDialog() == DialogResult.OK)
                    {
                        this.carrito += martillo.MartilloForm;
                        this.deposito.StockMartillo--;//se quita una unidad del depósito.
                    }
                    break;
                case 3:
                    FormTaladro taladro = new FormTaladro(herramienta);//para un taladro.

                    //Se asocia el manejador de evento al evento.
                    taladro.EventoDescuento += new FormTaladro.DelegadoTaladroBarato(this.ProductoConDescuento);
                    if (taladro.ShowDialog() == DialogResult.OK)
                    {
                        this.carrito += taladro.TaladroForm;
                        this.deposito.StockTaladro--;//se quita una unidad del depósito.
                    }
                    break;
            }
            //Se actualizan los datos de pantalla.
            this.ActualizarGroupBox();
            this.txtProdCarrito.Text = this.carrito.Carrito.Count.ToString();
            this.richtxtDetalle.Text = this.carrito.MostrarContenidoCarrito();//METODO DE EXTENSIÓN.
        }

        //Limpia los componenetes de lformulario principal
        private void LimpiarComponentes()
        {   
            this.richtxtDetalle.Clear();
            this.cmbMedioDePago.SelectedIndex = 0;
            this.txtProdCarrito.Text = "0";
            this.ActualizarGroupBox();
        }


        //A partir del indice del combo de herramientas seleccionado se verificará si hay stock disponible.Si no hay stock
        //se lanzará SinStockException.
        private bool VerificarStockDisponible(int indice)
        {
            bool respuesta = false;

            switch (indice)
            {
                case 0:
                    respuesta = int.Parse(this.txtSockCinta.Text) > 0;
                    break;
                case 1:
                    respuesta = int.Parse(this.txtStockEscalera.Text) > 0;
                    break;
                case 2:
                    respuesta = int.Parse(this.txtStockMartillo.Text) > 0;
                    break;
                case 3:
                    respuesta = int.Parse(this.txtStockTaladro.Text) > 0;
                    break;
            }

            if (!respuesta)
            {
                throw new SinStockException();
            }
            return respuesta;
        }


        //Método utilizado en el hilo creado anteriormente.
        private void StockearMercaderia()
        {
            //Se agregarán unidades al depósito siempre que ningun tipo de herramineta supere las 10 unidades.Si una lo supera no se agregarán más unidades
            while (this.deposito.StockCinta < 10 && this.deposito.StockEscalera < 10 && this.deposito.StockMartillo < 10 && this.deposito.StockTaladro < 10)
            {
                if (this.formStock.rTxtBox.InvokeRequired)//se pregunta por el control richtextbox del FormStock que muestra la reposicion de mercadería.
                {
                    this.formStock.rTxtBox.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.deposito.AgregarStock();//se actualizan unidades del depósito.
                        this.formStock.rTxtBox.Clear();//se limpia el área donde se visualizan el stock diponible.
                        this.formStock.rTxtBox.Text = this.deposito.ToString();//se le asigna el contenido con el stock actualizado.
                        this.ActualizarGroupBox();//se modifican al mismo tiempo los textbox que muestran en el form principal
                        //las unidades disponibles.

                    });
                }
                else
                {
                    this.deposito.AgregarStock();
                    this.formStock.rTxtBox.Clear();
                    this.formStock.rTxtBox.Text = this.deposito.ToString();
                    this.ActualizarGroupBox();
                }

                Thread.Sleep(4000);//se detiene 4 segundos.
            } 

            try
            {
                this.hiloStockeo.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception");
            }

        }


        //Actualiza el contenido de los txtbox que muestran en el form principal las unidaes disponibles al momento.
        private void ActualizarGroupBox()
        {
            this.txtSockCinta.Text = this.deposito.StockCinta.ToString();
            this.txtStockEscalera.Text = this.deposito.StockEscalera.ToString();
            this.txtStockMartillo.Text = this.deposito.StockMartillo.ToString();
            this.txtStockTaladro.Text = this.deposito.StockTaladro.ToString();
        }


        //Método asociado al evento del formTaladro que permite crear un taladro.
        //Método que advierte que se está por vender una herramiean con descuento.
        private void ProductoConDescuento(object obj,EventArgs ar)
        {
            MessageBox.Show("Al producto agregado se le aplico un descuento.");
        }
    }
}
