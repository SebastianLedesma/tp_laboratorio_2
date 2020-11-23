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
    //Formulario que mostrará la actualización de stock del deposito.
    //Se usa con hilos.
    public partial class FormStock : Form
    {
        public FormStock(Deposito deposito)
        {
            InitializeComponent();
            this.rTxtBox.Text = deposito.ToString();
        }
    }
}
