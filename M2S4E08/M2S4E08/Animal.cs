using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S4E08
{
    abstract class Animal
    {
        private string _nome { set; get; }
        private int _idade { set; get; }

        public abstract void EmitirSom();
    }
}
