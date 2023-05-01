using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E09
{
    static class Calculadora
    {

        public const double Pi = 3.14159265359;

        public static double Somar(double valor1, double valor2)
        {
           return valor1 + valor2;
        }

        public static double Subtracao(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public static double Multiplicacao(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public static double Divisao(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

    }
}
