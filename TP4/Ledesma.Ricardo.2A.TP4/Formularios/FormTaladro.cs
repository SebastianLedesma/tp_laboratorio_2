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

namespace Formularios
{
    public partial class FormTaladro : Form
    {
        //DELEGADO
        public delegate void DelegadoTaladroBarato(object obj, EventArgs ar);

        #region Atributo
        private Taladro taladroForm;
        #endregion

        //EVENTO
        public event DelegadoTaladroBarato EventoDescuento;

        #region Propiedad
        public Taladro TaladroForm
        {
            get { return this.taladroForm; }
        }
        #endregion


        //Recibe una herramienta creada en el FormHerramienta.Se tomarán sus atributos para instanciar un taladro.
        public FormTaladro(Herramienta herramienta)
        {
            InitializeComponent();
            this.taladroForm = new Taladro(herramienta.Distribuidor,herramienta.Precio,herramienta.PaisOrigen);
        }


        //Creación del taladro.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.taladroForm.peso = (Taladro.EPesoGramos)this.cmbEsRecargable.SelectedItem;
            this.taladroForm.tiempoTrabajo = (Taladro.ETiempoTrabajo)this.cmbTiempoTrabajo.SelectedItem;


            //Se invoca al evento.Para eso debe haber una instancia de taladro y su oringe debe ser Argentina.
            //Al aplicarse el descuento se dispara el evento.
            if (this.EventoDescuento != null && this.taladroForm.PaisOrigen.ToString().Equals("Argentina"))
            {
                this.EventoDescuento.Invoke(this,EventArgs.Empty);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        //Carga de datos previa
        private void FormTaladro_Load(object sender, EventArgs e)
        {
            //Llenado de los combobox.
            foreach (Taladro.ETiempoTrabajo item in Enum.GetValues(typeof(Taladro.ETiempoTrabajo)))
            {
                this.cmbTiempoTrabajo.Items.Add(item);
            }

            foreach (Taladro.EPesoGramos item in Enum.GetValues(typeof(Taladro.EPesoGramos)))
            {
                this.cmbEsRecargable.Items.Add(item);
            }

            this.cmbTiempoTrabajo.SelectedIndex = 0;
            this.cmbEsRecargable.SelectedIndex = 0;
        }
    }
}
