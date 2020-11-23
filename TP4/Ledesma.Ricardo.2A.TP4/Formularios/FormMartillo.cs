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
    //Formulario para la cracion de un martillo
    public partial class FormMartillo : Form
    {
        #region Atributo
        private Martillo martilloForm;
        #endregion

        #region Propiedad
        public Martillo MartilloForm
        {
            get { return this.martilloForm; }
        }
        #endregion


        //Recibe una herramineta creada en el FormHeeramineta.
        public FormMartillo(Herramienta herramienta)
        {
            InitializeComponent();
            this.martilloForm = new Martillo(herramienta.Distribuidor,herramienta.Precio,herramienta.PaisOrigen);
        }

        private void FormMartillo_Load(object sender, EventArgs e)
        {
            foreach (Martillo.ETipoMartillo item in Enum.GetValues(typeof(Martillo.ETipoMartillo)))
            {
                this.cmbTipoMartillo.Items.Add(item);
            }

            foreach (Martillo.ETipoDeMango item in Enum.GetValues(typeof(Martillo.ETipoDeMango)))
            {
                this.cmbTipoDeMango.Items.Add(item);
            }

            this.cmbTipoMartillo.SelectedIndex = 0;
            this.cmbTipoDeMango.SelectedIndex = 0;
        }

        //Se inicializaon los atributos restantes del martillo
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.martilloForm.TipoMartillo = (Martillo.ETipoMartillo)this.cmbTipoMartillo.SelectedItem;
            this.martilloForm.TipoDeMango = (Martillo.ETipoDeMango)this.cmbTipoDeMango.SelectedItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
