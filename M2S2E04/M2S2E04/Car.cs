using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S2E04
{
    internal class Car
    {
        private string name;
        private string model;
        private float kilometers;

        public Car(string name, string model, float kilometers)
        {
            this.name = name;
            this.model = model;
            this.kilometers = kilometers;
        }

        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public float Kilometers { get => kilometers; set => kilometers = value; }

        public string Info()
        {
            return name + " - " +  model + " - " + kilometers;
        }
    }
}
