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
    //Formulario que complemta la creación de una escalera.
    public partial class FormEscalera : Form
    {
        #region Atributo
        private Escalera escalera;
        #endregion

        #region Propiedad
        public Escalera EscaleraForm
        {
            get { return this.escalera; }
        }
        #endregion

        //Constructor que recibe una herramineta de la cual se obtendran sus atribtos para crear la escalera.
        public FormEscalera(Herramienta herramienta)
        {
            InitializeComponent();
            this.escalera = new Escalera(herramienta.Distribuidor,herramienta.Precio,herramienta.PaisOrigen);
        }


        //Carga de los datos necesarios para la creación de la escalera.
        private void FormEscalera_Load(object sender, EventArgs e)
        {

            //Llenado de los combobox.
            foreach (Escalera.EMaterial item in Enum.GetValues(typeof(Escalera.EMaterial)))
            {
                this.cmbMaterial.Items.Add(item);
            }

            foreach (Escalera.ETamaño item in Enum.GetValues(typeof(Escalera.ETamaño)))
            {
                this.cmbTamanio.Items.Add(item);
            }

            this.cmbMaterial.SelectedIndex = 0;
            this.cmbTamanio.SelectedIndex = 0;
        }

        private void cmbTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.escalera.Tamanio = (Escalera.ETamaño)this.cmbTamanio.SelectedItem;
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.escalera.Material = (Escalera.EMaterial)this.cmbMaterial.SelectedItem;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
