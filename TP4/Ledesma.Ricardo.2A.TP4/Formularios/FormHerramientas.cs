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
    //Formulario principal para la creación de una herramienta.
    public partial class FormHerramientas : Form
    {
        #region Atributo
        private Herramienta herramienta;
        #endregion

        #region Propiedad
        public Herramienta PropHerramienta
        {
            get { return this.herramienta; }
        }
        #endregion


        public FormHerramientas()
        {
            InitializeComponent();
        }


        //Se crea una herramienta que será usada en otro formulario.
        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            float precio;

            try
            {
                precio = float.Parse(this.txtPrecio.Text);

                this.herramienta = new Herramienta((Herramienta.EDistribuidor)this.cmbOrigen.SelectedItem
                                                     , precio
                                                     , (Herramienta.EOrigen)this.cmbOrigen.SelectedItem);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        //Carga de datos para la creación de una herramineta.
        private void FormHerramientas_Load(object sender, EventArgs e)
        {
            //Llenado de los combobox.
            foreach (Herramienta.EDistribuidor item in Enum.GetValues(typeof(Herramienta.EDistribuidor)))
            {
                this.cmbDistribuidor.Items.Add(item);
            }

            foreach (Herramienta.EOrigen item in Enum.GetValues(typeof(Herramienta.EOrigen)))
            {
                this.cmbOrigen.Items.Add(item);
            }

            this.cmbDistribuidor.SelectedIndex = 0;
            this.cmbOrigen.SelectedIndex = 0;
        }
    }
}
