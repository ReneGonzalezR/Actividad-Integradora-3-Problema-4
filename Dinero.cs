using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_3_Problema_4
{
    class Dinero
    {
        private int cantidad;
        private int resto;
        public Dinero() { }
        public void SetCantidad(int valor)
        {
            cantidad = valor;
        }
        public void obtenerDinero(ref string billete500, ref string billete200, ref string billete100, ref string billete50, ref string billete20,
            ref string moneda10, ref string moneda5, ref string moneda2, ref string moneda1)
        {
            billete500 = (cantidad / 500).ToString();
            resto = cantidad % 500;

            billete200 = (resto / 200).ToString();
            resto = resto % 200;

            billete100 = (resto / 100).ToString();
            resto = resto % 100;

            billete50 = (resto / 50).ToString();
            resto = resto % 50;

            billete20 = (resto / 20).ToString();
            resto = resto % 20;

            moneda10 = (resto / 10).ToString();
            resto = resto % 10;

            moneda5 = (resto / 5).ToString();
            resto = resto % 5;

            moneda2 = (resto / 2).ToString();
            resto = resto % 2;

            moneda1 = resto.ToString();
        }
    }
}
