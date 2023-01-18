using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Transporte
    {
        public Transporte(string patente, string modelo)
        {
            this.patente = patente;
            this.modelo = modelo;
        }

        public  string patente { get; set; }
        public string modelo { get; set;}

        public abstract string Acelerar();

        public abstract string Frenar();
    }
}
