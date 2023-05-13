using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S5E01.model
{
    public abstract class Cliente
    {
        private string _nome;
        private string _numeroConta;
        private double _saldo;
        private string _endereco;

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string NumeroConta
        {
            get
            {
                return _numeroConta;
            }

            set
            {
                _numeroConta = value;
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                _saldo = (double)value;
            }
        }

        public string Endereco
        {
            get
            {
                return _endereco;
            }

            set
            {
                _endereco = value;
            }
        }

        public virtual string ResumoCliente()
        {
            return "Cliente \n{" +
                "\nnome: " + Nome +
                "\nendereco: " + Endereco +
                "\nnumero da conta: " + NumeroConta +
                "\nsaldo: " + Saldo;
        }
    }
}
