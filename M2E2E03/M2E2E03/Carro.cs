using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2E2E03
{
    internal class Carro
    {
        public DateTime id { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string placa { get; set; }
        public string cor { get; set; }
        public Proprietario proprietario { get; set; }

        public Carro() { }

        public Carro(string modelo, string marca, string placa, string cor, Proprietario proprietario)
        {
            this.id = DateTime.Now;
            this.modelo = modelo;
            this.marca = marca;
            this.placa = placa;
            this.cor = cor;
            this.proprietario = proprietario;
        }
    }
}
