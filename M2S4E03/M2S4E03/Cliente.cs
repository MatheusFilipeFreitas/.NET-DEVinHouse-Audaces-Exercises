using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E03
{
    class Cliente
    {
        private string nome;
        private string cpf;

        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public string ToString => $"Cliente:{{Nome: {nome}, Cpf: {cpf} }}";
    }
}
