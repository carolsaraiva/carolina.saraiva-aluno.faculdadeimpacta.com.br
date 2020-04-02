using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraEMSystem
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Aqui se identifica um acoplamento onde na minha solução o formulario
        /// depende diretamente da classe Calculadora para realizar as funções aritméticas.
        /// </summary>
        private Calculadora calculadora;
        public Form1()
        {
            calculadora = new Calculadora();
            InitializeComponent();
        }

        private void somar_Click(object sender, EventArgs e)
        {
            resultado.Text = calculadora.Somar(GetValorA(), GetValorB()).ToString();
        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            resultado.Text = calculadora.Subtrair(GetValorA(), GetValorB()).ToString();
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            resultado.Text = calculadora.Multiplicar(GetValorA(), GetValorB()).ToString();

        }

        private void divisao_Click(object sender, EventArgs e)
        {
            resultado.Text = calculadora.Dividir(GetValorA(), GetValorB()).ToString();
        }

        private decimal GetValorA()
        {
            return Convert.ToDecimal(valorA.Text);
        }        
        private decimal GetValorB()
        {
            return Convert.ToDecimal(valorB.Text);
        }
    }
}
