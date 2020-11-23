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
    //Formulario que muestra las facturas guardadas en la base de datos.
    public partial class FormFacturas : Form
    {
        #region Atributo
        private List<Factura> facturas;
        #endregion


        public FormFacturas()
        {
            InitializeComponent();
            this.facturas = ConectorBaseDatos.ObtenerListaFacturas();//Al intanciarse se cargan las facturas de la BD y
            //se guardan en el atributo.
        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {
            this.ConfigurarDataGridView();
            this.dtgView.DataSource = this.facturas;
        }


        //Configuración del elemento DataGridView
        private void ConfigurarDataGridView()
        {
            this.dtgView.ReadOnly = false;
            this.dtgView.MultiSelect = false;
            this.dtgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        //Botón que eliminará in registro de l basede datos.Antes de eliminarlo serializará la factura para tener un registro
        //de la misma.
        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            Factura factura;
            int indice = this.dtgView.SelectedRows[0].Index;

            if (indice != -1)
            {
                factura = this.facturas[indice];//se obtiene la factura seleccionada de datagridview.

                if (factura.GuardarInformacion())//se serializa
                {
                    MessageBox.Show("Se serializo la factura que quiere eliminar.");
                }

                if (!ConectorBaseDatos.EliminarFactura(factura))//se borra de la base de datos
                {
                    MessageBox.Show("No se pudo eliminar la factura","Error");
                }
                else
                {
                    MessageBox.Show("Se elimino la factura de la BD.", "Eliminacion de factura");
                }

                this.facturas = ConectorBaseDatos.ObtenerListaFacturas();//se traen todos los registrso acutalizado de la BD.
                this.dtgView.DataSource = this.facturas;//se muetran en el control.
            }
        }
    }
}
