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
    //Formulario que complementa la creación de una cinta métrica.
    public partial class FormCinta : Form
    {
        #region Atributo
        private CintaMetrica cintaForm;
        #endregion

        #region Propiedad
        public CintaMetrica CintaForm
        {
            get { return this.cintaForm; }
        }
        #endregion

        //Constructor que recibe una herramienta de la cual se tomarán los valores para sus atributos.
        public FormCinta(Herramienta herramienta)
        {
            InitializeComponent();
            this.cintaForm = new CintaMetrica(herramienta.Distribuidor, herramienta.Precio, herramienta.PaisOrigen);
        }


        //Al hace click en aceptar se guarda en la porpiedad la cinta creada.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.cintaForm.LargoCinta = (CintaMetrica.ELargoCintaMts)this.cmbLargoCinta.SelectedItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        //Carga de los datos necesario para poder crear un cinta.
        private void FormCinta_Load(object sender, EventArgs e)
        {
            //Llenado de los combobox.
            foreach (CintaMetrica.ELargoCintaMts item in Enum.GetValues(typeof(CintaMetrica.ELargoCintaMts)))
            {
                this.cmbLargoCinta.Items.Add(item);
            }

            foreach (CintaMetrica.EMaterial item in Enum.GetValues(typeof(CintaMetrica.EMaterial)))
            {
                this.cmbMaterial.Items.Add(item);
            }


            this.cmbMaterial.SelectedIndex = 0;
            this.cmbLargoCinta.SelectedIndex = 0;
        }
    }
}
