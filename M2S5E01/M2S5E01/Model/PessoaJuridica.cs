using M2S5E01.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S5E01.Model
{
    public class PessoaJuridica:Cliente
    {
        private string _cnpj;
        private string _razaoSocial;
        private string _inscricaoEstadual;

        public string Cnpj
        {
            get
            {
                return _cnpj;
            }

            set
            {
                _cnpj = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return _razaoSocial;
            }

            set
            {
                _razaoSocial = value;
            }
        }

        public string InscricaoEstadual
        {
            get
            {
                return _inscricaoEstadual;
            }

            set
            {
                _inscricaoEstadual = value;
            }
        }

        public PessoaJuridica()
        {

        }

        public override string ResumoCliente()
        {
            return base.ResumoCliente()+
                "\ncnpj: " + Cnpj +
                "\nrazao social: " + RazaoSocial +
                "\ninscricao estadual: " + InscricaoEstadual +
                "\n}\n";
        }

    }
}
