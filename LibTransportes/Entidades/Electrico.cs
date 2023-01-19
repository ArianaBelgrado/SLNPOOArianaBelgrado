using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Electrico : Transporte
    {
            public Electrico( string modelo, string patente, string bateriaDuracion, string voltaje) : base(modelo, patente) { 
                
                BateriaDuracion = bateriaDuracion;
                Voltaje = voltaje;
            }

            public string BateriaDuracion { get; set; }
            public string Voltaje { get; set; }

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
