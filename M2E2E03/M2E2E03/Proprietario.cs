using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2E2E03
{
    internal class Proprietario
    {
        public DateTime id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }

        public Proprietario() { }

        public Proprietario(string nome, string cpf, string telefone)
        {
            this.id = DateTime.Now;
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
        }
    }
}
