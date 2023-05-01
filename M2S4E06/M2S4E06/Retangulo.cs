using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E06
{
    class Retangulo
    {
        private double _altura;
        private double _largura;

        public double Altura {
            get
            {
                return _altura;
            }
            set
            {
                if(value > 0) _altura = value;
                else _altura = 0;
            }
        }

        public double Largura
        {
            get
            {
                return _largura;
            }
            set
            {
                if (value > 0) _largura = value;
                else _largura = 0;
            }
        }

        public double CalculaArea()
        {
            return _largura * _altura;
        }
    }
}
