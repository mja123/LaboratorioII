using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioHerencia
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private void rbPiso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPiso.Checked)
            {
                txtVentanas.Enabled = false;
                txtNroPiso.Enabled = true;

            } else
            {
                txtVentanas.Enabled = true;
                txtNroPiso.Enabled = false;
            }
        }
        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {

            int superficie = Utiles.validarDatosInt(txtSuperficie.Text);
            int antiguedadInt = Utiles.validarDatosInt(txtAntiguedad.Text);
            int nroPisoInt = Utiles.validarDatosInt(txtNroPiso.Text);
            int nroVentanas = Utiles.validarDatosInt(txtVentanas.Text);
            float precioBaseFloat = Utiles.validarDatosFloat(txtPrecioBase.Text);
            Boolean datosCorrectos = true;

            if (txtDireccion.Text == "") 
            {
                datosCorrectos = false;
                txtDireccion.BackColor = System.Drawing.Color.Orange;
            } else
            {
                txtDireccion.BackColor = System.Drawing.Color.White;

            }

            if (superficie == -1 || !Utiles.rangoDatoIngresado(superficie))
            {
                datosCorrectos = false;
                txtSuperficie.BackColor = System.Drawing.Color.Orange;
                txtSuperficie.Text = "";
            } else
            {
                txtSuperficie.BackColor = System.Drawing.Color.White;

            }
            if (antiguedadInt == -1 || !Utiles.rangoDatoIngresado(antiguedadInt))
            {
                datosCorrectos = false;
                txtAntiguedad.BackColor = System.Drawing.Color.Orange;
                txtAntiguedad.Text = "";
            }
            else
            {
                txtAntiguedad.BackColor = System.Drawing.Color.White;                
            }
            if ((nroPisoInt == -1 || !Utiles.rangoDatoIngresado(nroPisoInt)) && txtNroPiso.Enabled)
            {
                datosCorrectos = false;
                txtNroPiso.BackColor = System.Drawing.Color.Orange;
                txtNroPiso.Text = "";
            }
            else
            {
                txtNroPiso.BackColor = System.Drawing.Color.White;
            }
            if (precioBaseFloat == -1 || !Utiles.rangoDatoIngresado(0, precioBaseFloat))
            {
                datosCorrectos = false;
                txtPrecioBase.BackColor = System.Drawing.Color.Orange;
                txtPrecioBase.Text = "";
            }
            else
            {
                txtPrecioBase.BackColor = System.Drawing.Color.White;   
            }
            if ((nroVentanas == -1  || !Utiles.rangoDatoIngresado(nroVentanas)) && txtVentanas.Enabled)
            {
                datosCorrectos = false;
                txtVentanas.BackColor = System.Drawing.Color.Orange;
                txtVentanas.Text = "";
            }
            else
            {
                txtVentanas.BackColor = System.Drawing.Color.White;
            }
            if (datosCorrectos)
            {

                if (rbPiso.Checked)
                {
                    Piso miPiso = new Piso(txtDireccion.Text, superficie, antiguedadInt, precioBaseFloat, nroPisoInt);
                    lblTotal.Text = "El precio final del Piso es: $" + miPiso.precioFinal(); 
                }
                else
                {
                    Local miLocal = new Local(txtDireccion.Text, superficie, antiguedadInt, precioBaseFloat, nroVentanas);
                    lblTotal.Text = "El precio final del Local es: $" + miLocal.precioFinal();
                }
            }
            else
            {
                MessageBox.Show("Los casilleros en anaranjado tienen datos erroneos. Por favor, intenta nuevamente.", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
