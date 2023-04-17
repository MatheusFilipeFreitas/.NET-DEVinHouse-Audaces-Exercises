using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace M2S2E10
{
    internal class Calculadora
    {
        public Boolean Menu()
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("1 - Somar;");
            Console.WriteLine("2 - Subtrair;");
            Console.WriteLine("3 - Multiplicar;");
            Console.WriteLine("4 - Dividir;");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Opcao: ");
            int option = int.Parse(s: Console.ReadLine());
            switch (option)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Sub();
                    break;
                case 3:
                    Mult();
                    break;
                case 4:
                    Div();
                    break;
                case 5:
                    return false;
                default:
                    Console.WriteLine("Opcao invalida!");
                    break;
            }
            return true;
        }



        public static void Sum()
        {
            Console.WriteLine("Numero 1: ");
            int num1 = int.Parse(s: Console.ReadLine());

            Console.WriteLine("Numero 2: ");
            int num2 = int.Parse(s: Console.ReadLine());

            Console.WriteLine("Result: " + (num1 + num2));
        }

        public static void Sub()
        {
            Console.WriteLine("Numero 1: ");
            int num1 = int.Parse(s: Console.ReadLine());

            Console.WriteLine("Numero 2: ");
            int num2 = int.Parse(s: Console.ReadLine());

            Console.WriteLine("Result: " + (num1 - num2));
        }

        public static void Mult()
        {
            Console.WriteLine("Numero 1: ");
            int num1 = int.Parse(s: Console.ReadLine());

            Console.WriteLine("Numero 2: ");
            int num2 = int.Parse(s: Console.ReadLine());

            Console.WriteLine("Result: " + (num1 * num2));
        }

        public static void Div()
        {
            Console.WriteLine("Numero 1: ");
            int num1 = int.Parse(s: Console.ReadLine());

            Console.WriteLine("Numero 2: ");
            int num2 = int.Parse(s: Console.ReadLine());

            Console.WriteLine("Result: " + (num1 / num2));
        }
    }
}
