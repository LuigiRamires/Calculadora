using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            double v1, v2;
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);

            Calculadora calculadora = new Calculadora();
            lblResultado.Text = calculadora.Somar(v1, v2).ToString();

        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            double v1, v2;
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);
            Calculadora calculadora = new Calculadora();
            lblResultado.Text = calculadora.Subtrair(v1, v2).ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            double v1, v2;
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);

            if (v2 != 0)
            {
                Calculadora calculadora = new Calculadora();
                lblResultado.Text = calculadora.dividir(v1, v2).ToString();
            }
            else
            {
                MessageBox.Show("Não se pode dividir por 0", "Atenção");
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            double v1, v2;
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);
            Calculadora calculadora = new Calculadora();
            lblResultado.Text = calculadora.multiplicar(v1, v2).ToString();
        }
    }
}
