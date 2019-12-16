using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDelegate
{
    // Declaração do delegate Calcular, os métodos que serão atribuidos ao objeto delegate deverão ter a mesma assinatura 
    public delegate int Calcular(int valor1, int valor2);

    class Calculadora
    {
        public int Somar(int valor1, int valor2)
        {
            return (valor1 + valor2);
        }

        public int Subtrair(int valor1, int valor2)
        {
            return (valor1 - valor2);
        }

        public int Multiplicar(int valor1, int valor2)
        {
            return (valor1 * valor2);
        }

        public int Dividir(int valor1, int valor2)
        {
            return (valor1 / valor2);
        }
    }
}
