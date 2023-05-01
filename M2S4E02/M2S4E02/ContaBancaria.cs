using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E02
{
    class ContaBancaria
    {
        private string numeroConta;
        private double saldo;

        public ContaBancaria(string numeroConta, double saldo)
        {
            this.numeroConta = numeroConta;
            this.saldo = saldo;
        }

        public void Deposita(double valor)
        {
            saldo += valor;
        }

        public void Saca(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }
}
