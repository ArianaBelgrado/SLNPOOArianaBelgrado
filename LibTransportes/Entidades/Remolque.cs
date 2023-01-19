using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Remolque
    {
        public Remolque(int ruedas, string color)
        {
            this.ruedas = ruedas;
            this.color = color;
        }

        public int ruedas { get; set; }

        public string color { get; set; }
    }
}
