using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Camion : Transporte 
    {
        public Camion(string patente, string modelo, double pesoTotal, int trailers, double alturaMaxima) : base(modelo, patente)
        {
            Trailers = trailers;
            AlturaMaxima = alturaMaxima;
        }

        public int Trailers { get; set; }
        public double AlturaMaxima { get; set; }

        public abstract string Acelerar();

        public abstract string Frenar();


    }
}
