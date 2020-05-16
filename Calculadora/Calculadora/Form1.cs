﻿using System;
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
        double v1, v2;
        Calculadora calculadora = new Calculadora();

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void atribuindoValor()
        {
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            atribuindoValor();
            lblResultado.Text = calculadora.Somar(v1, v2).ToString();
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            atribuindoValor();
            lblResultado.Text = calculadora.Subtrair(v1, v2).ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            atribuindoValor();
            lblResultado.Text = calculadora.dividir(v1, v2).ToString();
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            atribuindoValor();
            lblResultado.Text = calculadora.multiplicar(v1, v2).ToString();
        }
    }
}
