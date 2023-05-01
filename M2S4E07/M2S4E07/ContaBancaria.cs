﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E07
{
    class ContaBancaria
    {
        public const double SaldoMax = 1000.00;
        private int _numeroDaConta;
        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0 || (valor + Saldo) > SaldoMax)
            {
                Console.WriteLine("Valor nao permitido");
            }
            else 
            { 
                Saldo += valor;
            }
        }
        public void Sacar(double valor)
        {
            if (valor < 0 && valor > Saldo)
            {
                Console.WriteLine("Valor nao permitido!");
            }
            else 
            { 
                Saldo -= valor; 
            }
        }
    }
}
