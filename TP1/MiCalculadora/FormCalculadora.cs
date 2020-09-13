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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Evento que al ser invocado toma los valores de las cajas de texto y combo box
        /// y realiza las opereciones para hacer una operacion aritmetica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            this.lblResultado.Text = "";

            if (this.txtNumero1.Text != "" && this.txtNumero2.Text != "" && this.cmbOperador.SelectedIndex != -1)
            {
                resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.SelectedItem.ToString());

                this.lblResultado.Text = resultado.ToString();

                this.btnConvertirABinario.Enabled = true;
                this.btnConvertirADecimal.Enabled = false;
            }
           
        }


        /// <summary>
        /// Evento que al ser invocado limpia los campos en los que se escribio informacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = false;
        }



        /// <summary>
        /// Evento que al ser invocado cierra el formulario directamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Evento que al ser invocado toma el valor del lblResultado y realiza
        /// las operacion para convertir el valor a nro binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero nro = new Numero();

            if (this.lblResultado.Text != "" && this.lblResultado.Text != "Valor invalido")
            {
                this.lblResultado.Text = nro.DecimalBinario(this.lblResultado.Text);
                this.btnConvertirABinario.Enabled = false;
                this.btnConvertirADecimal.Enabled = true;
            }
        }

        /// <summary>
        /// Evento que al ser invocado toma el valor del elemento lblResultado y realiza
        /// las operaciones para convertirlo a nro decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero nro = new Numero();

            if (this.lblResultado.Text != "" && this.lblResultado.Text != "Valor invalido")
            {
                this.lblResultado.Text = nro.BinarioDecimal(this.lblResultado.Text);
                this.btnConvertirADecimal.Enabled = false;
                this.btnConvertirABinario.Enabled = true;
            }
        }


        /// <summary>
        /// Metodo estatico que permite obtener el resultado de una operacion aritmetica.
        /// </summary>
        /// <param name="numero1"></param>Cadena obtenida de una caja de texto.
        /// <param name="numero2"></param>Cadena obtenida de una caja de texto.
        /// <param name="operador"></param>Valor obtenido de un combo box.
        /// <returns>Retorna el valor de la operacion realizada segun los datos obtenidos de los elementos del formulario.</returns>
        private static double Operar(string numero1,string numero2,string operador)
        {
            Numero nro1 = new Numero(numero1);
            Numero nro2=new Numero(numero2);

            return Calculadora.Operar(nro1,nro2,operador);
        }


        /// <summary>
        /// Metodo que borra los datos ingredados y resultador obtenidos.
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text = "";
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = -1;
        }
    }
}
