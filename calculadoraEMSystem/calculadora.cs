using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraEMSystem
{

    /// <summary>
    /// Aqui se identifica uma coesão onde dentro de uma mesma classe encontramos todos os métodos
    /// referente as funções aritméticas da calculadora.
    /// </summary>
    public class Calculadora
    {
        public decimal Somar(decimal valorA, decimal valorB)
        {
            return valorA + valorB;
        }
        public decimal Subtrair(decimal valorA, decimal valorB)
        {
            return valorA - valorB;
        }
        public decimal Multiplicar(decimal valorA, decimal valorB)
        {
            return valorA * valorB;
        }
        public decimal Dividir(decimal valorA, decimal valorB)
        {
            return valorA / valorB;
        }
    }
}
