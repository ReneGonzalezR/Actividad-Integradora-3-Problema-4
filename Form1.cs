using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_3_Problema_4
{
    public partial class Form1 : Form
    {
        Dinero dinero = new Dinero();
        public Form1()
        {
            InitializeComponent();
            dinero.SetCantidad(0);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            string billete500 = string.Empty, billete200 = string.Empty, billete100 = string.Empty, billete50 = string.Empty,
                billete20 = string.Empty, moneda10 = string.Empty, moneda5 = string.Empty, moneda2 = string.Empty, moneda1 = string.Empty;
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                dinero.SetCantidad(0);
            }
            else
            {
                dinero.SetCantidad(Convert.ToInt32(txtCantidad.Text));
            }
            

            dinero.obtenerDinero(ref billete500, ref billete200, ref billete100, ref billete50, ref billete20, ref moneda10, ref moneda5, ref moneda2, ref moneda1);
            lblBillete500.Text = billete500;
            lblBillete200.Text = billete200;
            lblBillete100.Text = billete100;
            lblBillete50.Text = billete50;
            lblBillete20.Text = billete20;
            lblMoneda10.Text = moneda10;
            lblMoneda5.Text = moneda5;
            lblMoneda2.Text = moneda2;
            lblMoneda1.Text = moneda1;
        }
    }
}
