using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Camion : Transporte 
    {
        public Camion(string patente, string modelo, int trailers, double alturaMaxima) : base(modelo, patente)
        {
            Trailers = trailers;
            AlturaMaxima = alturaMaxima;
        }

        public int Trailers { get; set; }
        public double AlturaMaxima { get; set; }

        public override string Acelerar()
        {
            return "El camion acelerando";
        }

        public override string Frenar()
        {
            return "El camion freno";
        }
        public string Quitarremolque()
        {
            return null;
        }


    }
}
