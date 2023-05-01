using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E03
{
    internal class Banco
    {
        private double saldo;

        public void Sacar(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
            }   
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public string ToString => $"Banco:{{Saldo: {saldo} }}";
    }
}
