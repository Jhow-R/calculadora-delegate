using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDelegate
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        int valor1 = 0;
        int valor2 = 0;

        // Objeto que contém os métodos da calculadora que serão atribuidos aos delegates
        static Calculadora calc = new Calculadora();

        // Objetos delegates recebendo os métodos com a assinatura EXATA do delegate
        Calcular Somar = new Calcular(calc.Somar);
        Calcular Subtrair = new Calcular(calc.Subtrair);
        Calcular Multiplicar = new Calcular(calc.Multiplicar);
        Calcular Dividir = new Calcular(calc.Dividir);
        //Ou Calcular Dividir = new Calcular(new Calculadora().Dividir);

        private void btnSomar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtVal1.Text);
            valor2 = Convert.ToInt32(txtVal2.Text);
            txtResultado.Text = Somar(valor1, valor2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtVal1.Text);
            valor2 = Convert.ToInt32(txtVal2.Text);
            txtResultado.Text = Subtrair(valor1, valor2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtVal1.Text);
            valor2 = Convert.ToInt32(txtVal2.Text);
            txtResultado.Text = Multiplicar(valor1, valor2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtVal1.Text);
            valor2 = Convert.ToInt32(txtVal2.Text);
            txtResultado.Text = Dividir(valor1, valor2).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVal1.Clear();
            txtVal2.Clear();
            txtResultado.Clear();
            txtVal1.Focus();
        }
    }
}
