using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E10
{
    internal class Transacao
    {
        private string _nome;
        private DateOnly _date;
        private double _valor;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public DateOnly Date { get { return _date; } set { _date = value; } }
    
        public double Valor { get { return _valor; } set { _valor = value; } }
    }
}
