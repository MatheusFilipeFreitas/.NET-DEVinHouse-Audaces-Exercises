using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S5E01
{
    internal class PessoaFisica: Cliente
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
            if(idade >= 18)
            {
                return true;
            }
            return false;
        }

        override public void ResumoCliente()
        {
            Console.WriteLine("Cliente \n{" +
                "\nnome: " + Nome +
                "\nendereco: " + Endereco +
                "\ncpf: " + Cpf +
                "\nnumero da conta: " + NumeroConta +
                "\nsaldo: " + Saldo +
                "\n}\n");
        }

    }
}
