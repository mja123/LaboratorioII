using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFinal
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void rdbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            ckbShortPants.Enabled = false;
            ckbshirtSleeve.Enabled = true;
        }

        private void rdbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            ckbshirtSleeve.Enabled = false;
            ckbShortPants.Enabled = true;
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            bool dataIncorrect = false;
            int count = Controller.Validation.intValidation(txtCount.Text, 0, 1000);
            int price = Controller.Validation.intValidation(txtPrice.Text, 0, 1000);

            txtCount.BackColor = System.Drawing.Color.White;
            txtPrice.BackColor = System.Drawing.Color.White;

            if (count == -1)
            {
                dataIncorrect = true;
                txtCount.BackColor = System.Drawing.Color.Orange;
            }
            if (price == -1)
            {
                dataIncorrect = true;
                txtPrice.BackColor = System.Drawing.Color.Orange;
            }
            if (!dataIncorrect)
            {               
                if (rdbPants.Checked)
                {
                    if (rdbPants.Checked)
                    {
                        Controller.MainController.chosenClothing("pants", count, price, ckbShortPants.Checked, rdbStandard.Checked);
                        form2.showFinalPrice(getFinalPrice("pants"));
                        form2.ShowDialog();
                        
                    }                  
                } else
                {
                    if (rdbShirt.Checked)
                    {
                        Controller.MainController.chosenClothing("shirt", count, price, ckbshirtSleeve.Checked, rdbStandard.Checked);
                        form2.showFinalPrice(getFinalPrice("shirt"));
                        form2.ShowDialog();
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Los casilleros que se encuentran en anaranjado presentan datos incorrectos. Por favor, intente nuevamente", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getFinalPrice(string type)
        {
            return Convert.ToString(Controller.MainController.showFinalPrice(type));
        }
    }
}
