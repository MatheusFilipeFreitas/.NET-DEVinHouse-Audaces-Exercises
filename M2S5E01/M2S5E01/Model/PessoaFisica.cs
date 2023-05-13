using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S5E01.model
{
    internal class PessoaFisica : Cliente
    {
        private string _cpf;
        private DateTime _dataNascimento;

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                _cpf = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return _dataNascimento;
            }

            set
            {
                _dataNascimento = value;
            }
        }

        public bool EhMaior()
        {
            DateTime today = DateTime.Today.Date;

            int idade = today.Year - DataNascimento.Year;
            if (idade >= 18)
            {
                return true;
            }
            return false;
        }

        public override string ResumoCliente()
        {
            return base.ResumoCliente() + 
                "\ncpf: " + Cpf +
                "\n}\n";
        }

    }
}
