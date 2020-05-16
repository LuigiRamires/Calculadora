using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                System.Windows.Forms.MessageBox.Show("Não se pode dividir por 0", "Atenção");
                return 0;
            }
            else
            {
                return valor1 / valor2;
            }

        }
    }
}
