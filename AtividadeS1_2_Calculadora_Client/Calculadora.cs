using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeS1_2_Calculadora_Client
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            Service.Calculadora.CalculatorClient servico = new Service.Calculadora.CalculatorClient();

            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);

            if (rbtSomar.Checked)
            {
                lblResultado.Text = servico.Somar(valor1, valor2).ToString("0.00");
            }
            else if (rbtSubtrair.Checked)
            {
                lblResultado.Text = servico.Subtrair(valor1, valor2).ToString("0.00");
            }
            else if (rbtMultiplicar.Checked)
            {
                lblResultado.Text = servico.Multiplicar(valor1, valor2).ToString("0.00");
            }
            else if (rbtDividir.Checked)
            {
                lblResultado.Text = servico.Dividir(valor1, valor2).ToString("0.00");
            }
        }
    }
}
