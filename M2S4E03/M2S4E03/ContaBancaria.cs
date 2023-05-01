using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E03
{
    class ContaBancaria
    {
        private string numero;
        private Cliente cliente;
        private Banco banco = new Banco();

        public ContaBancaria(string numero, Cliente cliente)
        {
            this.numero = numero;
            this.cliente = cliente;
        }

        public string ExibirDados()
        {
            return $"ContaBancaria: {{Numero: {numero}, Cliente: {{ {cliente.ToString()} }} }}";
        }

        public void Depositar(double valor) => banco.Depositar(valor);

        public void Sacar(double valor) => banco.Sacar(valor);

        public string ToString => $"{ExibirDados()}, {banco}";
    }
}
