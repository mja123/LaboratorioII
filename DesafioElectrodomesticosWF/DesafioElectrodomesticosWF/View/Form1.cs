using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesafioElectrodomesticosWF
{
    public partial class form1 : Form
    {
        private Controller.ControllerMain validarDatos;
        private bool errorEnDato = false;
        private int totalElectro = 0;
        private int totalTelevisor = 0;
        private int totalLavadora = 0;
        public form1()
        {
            InitializeComponent();
        }

        private void rbtElectrodomestico_CheckedChanged(object sender, EventArgs e)
        {
            txtCarga.Enabled = false;
            txtResolucion.Enabled = false;
            chbSintonizador.Enabled = false; 
        }

        private void rdtLavadora_CheckedChanged(object sender, EventArgs e)
        {
            txtCarga.Enabled = true;
            txtResolucion.Enabled = false;
            chbSintonizador.Enabled = false;
            
        }

        private void rdtTelevisor_CheckedChanged(object sender, EventArgs e)
        {
            txtResolucion.Enabled = true;
            chbSintonizador.Enabled = true;
            txtCarga.Enabled = false;
            
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            errorEnDato = false;
            if (rbtElectrodomestico.Checked)
            {
                validarDatos = new Controller.ControllerMain(txtPeso.Text, txtColor.Text, txtConsumo.Text, txtPrecio.Text);
                errorEnDato = false;
                foreach (string error in validarDatos.errores())                       
                {
                    if (error == "precio")
                    {
                        txtPrecio.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtPrecio.Text = "";
                    }

                    if (error == "color")
                    {
                        txtColor.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtColor.Text = "";
                    }

                    if (error == "consumo")
                    {
                        txtConsumo.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtConsumo.Text = "";
                    }

                    if (error == "peso")
                    {
                        txtPeso.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtPeso.Text = "";
                    }

                }

                if (errorEnDato)
                {
                    MessageBox.Show("Los casilleros en anaranjado tienen datos erroneos. Por favor, intenta nuevamente.", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    errorEnDato = false;
                    txtPeso.BackColor = System.Drawing.Color.White;
                    txtConsumo.BackColor = System.Drawing.Color.White;
                    txtColor.BackColor = System.Drawing.Color.White;
                    txtPrecio.BackColor = System.Drawing.Color.White;

                    totalElectro += validarDatos.calcularTotal();
                    txtTotalElectro.Text = Convert.ToString(totalElectro);
                }
            }
            
            if (rdtLavadora.Checked)
            {
                validarDatos = new Controller.ControllerMain(txtPeso.Text, txtColor.Text, txtConsumo.Text, txtPrecio.Text, txtCarga.Text);
                errorEnDato = false;
                foreach (string error in validarDatos.errores())
                {

                    if (error == "precio")
                    {
                        txtPrecio.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtPrecio.Text = "";
                    }

                    if (error == "color")
                    {
                        txtColor.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtColor.Text = "";
                    }
                   
                    if (error == "consumo")
                    {
                        txtConsumo.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtConsumo.Text = "";
                    }

                    if (error == "peso")
                    {
                        txtPeso.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtPeso.Text = "";
                    }
                    if (error == "carga")
                    {
                        txtCarga.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                    }

                }
                if (errorEnDato)
                {
                    MessageBox.Show("Los casilleros en anaranjado tienen datos erroneos. Por favor, intenta nuevamente.", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    errorEnDato = false;
                    txtPeso.BackColor = System.Drawing.Color.White;
                    txtConsumo.BackColor = System.Drawing.Color.White;
                    txtColor.BackColor = System.Drawing.Color.White;
                    txtPrecio.BackColor = System.Drawing.Color.White;
                    txtCarga.BackColor = System.Drawing.Color.White;


                    totalLavadora += validarDatos.calcularTotal();
                    txtTotalLavadora.Text = Convert.ToString(totalLavadora);
                    totalElectro += validarDatos.calcularTotal();
                    txtTotalElectro.Text = Convert.ToString(totalElectro);
                }
            }

            if (rdtTelevisor.Checked)
            {
                validarDatos = new Controller.ControllerMain(txtPeso.Text, txtColor.Text, txtConsumo.Text, txtPrecio.Text, txtResolucion.Text, chbSintonizador.Checked);
                errorEnDato = false;
                foreach (string error in validarDatos.errores())
                {
                    if (error == "precio")
                    {
                        txtPrecio.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtPrecio.Text = "";
                    }

                    if (error == "color")
                    {
                        txtColor.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtColor.Text = "";
                    }

                    if (error == "consumo")
                    {
                        txtConsumo.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtConsumo.Text = "";
                    }

                    if (error == "peso")
                    {
                        txtPeso.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtPeso.Text = "";
                    }

                    if (error == "resolucion")
                    {
                        txtResolucion.BackColor = System.Drawing.Color.Orange;
                        errorEnDato = true;
                        txtResolucion.Text = "";
                    }

                }
                if (errorEnDato)
                {
                    MessageBox.Show("Los casilleros en anaranjado tienen datos erroneos. Por favor, intenta nuevamente.", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    errorEnDato = false;
                    txtPeso.BackColor = System.Drawing.Color.White;
                    txtConsumo.BackColor = System.Drawing.Color.White;
                    txtColor.BackColor = System.Drawing.Color.White;
                    txtPrecio.BackColor = System.Drawing.Color.White;
                    txtResolucion.BackColor = System.Drawing.Color.White;

                    totalTelevisor += validarDatos.calcularTotal();
                    txtTotalTele.Text = Convert.ToString(totalTelevisor);
                    totalElectro += validarDatos.calcularTotal();
                    txtTotalElectro.Text = Convert.ToString(totalElectro);
                }
            }

        }
        
    }
}
