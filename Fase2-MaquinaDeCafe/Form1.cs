using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_MaquinaDeCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBolacha_Click(object sender, EventArgs e)
        {
            double produto = 4;

            if (Double.Parse(lblSaldo.Text.Replace("R$ ", "")) >= produto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$ ", ""));
                double consumo = -produto;

                double resultado = saldo + consumo;
                lblSaldo.Text = "R$ " + resultado;
            }
            else
            {
                MessageBox.Show("Saldo invalido");
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double valor;
            double saldo;

            valor = Double.Parse(txtNovoSaldo.Text);
            saldo = Double.Parse(lblSaldo.Text.Replace("R$ ", ""));

            double soma = valor + saldo;
            lblSaldo.Text = "R$ " + soma;
        }

        private void btnSalgadinho_Click(object sender, EventArgs e)
        {
            double produto = 7;

            if (Double.Parse(lblSaldo.Text.Replace("R$ ", "")) >= produto)
            {
                double saldo;
                saldo = Double.Parse(lblSaldo.Text.Replace("R$ ", ""));
                double consumo = -produto;

                double resultado = saldo + consumo;
                lblSaldo.Text = "R$ " + resultado;
            }
            else
            {
                MessageBox.Show("Saldo invalido");
            }
        }
    }
}
