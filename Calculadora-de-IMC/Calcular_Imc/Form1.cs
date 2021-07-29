using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            textPeso.Text = "";
            textAltura.Text = "";
            textImc.Text = "";
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntVerificar_Click(object sender, EventArgs e)
        {
            CalcularIMC cImc = new CalcularIMC();
            double r = cImc.Imc(Double.Parse(textPeso.Text), Double.Parse(textAltura.Text));
            textImc.Text = r.ToString("0.00");

            if (r < 18.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do peso", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (r < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com peso dentro da Normalidade", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (r < 29.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do peso", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (r < 34.99)
                MessageBox.Show("ATENÇÃO! Você está com Obesidade Grau I", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (r < 39.99)
                MessageBox.Show("ATENÇÃO! Você está com Obesidade Grau II", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("ATENÇÃO! Você está com Obesidade Grau III (mórbida)", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string x = "http://www.calculoimc.com.br/";
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + x);
        }
    }
}
