using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Auto : Transporte
    {
        public int Ruedas { get; set; }
        public int Capacidad { get; set; }
        public string Color { get; set; }

        public Auto(string modelo, string transporte, int ruedas, int capacidad, string color) : base(modelo, transporte)
        {
            Ruedas = ruedas;
            Capacidad = capacidad;
            Color = color;
        }

        public override string Acelerar()
        {
            return "El auto esta acelerando";
        }

        public override string Frenar()
        {
            return "El auto freno";
        }

    }
}
