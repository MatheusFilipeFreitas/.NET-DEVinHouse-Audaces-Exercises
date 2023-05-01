using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E10
{
    internal class ContaBancaria
    {
        private double _saldo;
        private List<Transacao> transacaos = new List<Transacao>();
        public void Depositar(double value)
        {
            _saldo += value;
            Transacao transacao = new Transacao();
            transacao.Nome = "Deposito";
            transacao.Date = new DateOnly();
            transacao.Valor = value;
            transacaos.Add(transacao);
        }

        public void Sacar(double value)
        {
            if(value <= _saldo)
            {
                _saldo -= value;
                Transacao transacao = new Transacao();
                transacao.Nome = "Saque";
                transacao.Date = new DateOnly();
                transacao.Valor = value;
                transacaos.Add(transacao);
            }
        }

        public double getSaldo()
        {
            return _saldo;
        }

        public void HistoricoTransacoes()
        {
            foreach(Transacao transacao in transacaos)
            {
                Console.WriteLine(value: $"[{transacao.Date}] {transacao.Nome} - valor: {transacao.Valor}");
            }
        }

    }
}
