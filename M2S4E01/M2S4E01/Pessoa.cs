using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E01
{
    class Pessoa
    {
        private string nome;
        protected int idade;
        public string endereco;

        public Pessoa(string nome, int idade, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }

        public string Saudacao()
        {
            return $"Ola, meu nome é {nome} e eu tenho {idade} anos";
        }
    }
}
