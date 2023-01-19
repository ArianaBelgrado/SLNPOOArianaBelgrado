using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes.Entidades;

namespace nombre_WindowsEFDatos
{
    public partial class CamionyRemolque : Form
    {
        public CamionyRemolque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camion camion1 = new Camion("NGQ 486", "2013", 5, 5) { };

            MessageBox.Show($"Camion patente: {camion1.patente}\n" +
                            $"Camion modelo: {camion1.modelo}\n"+ 
                            $"Camion trailers: {camion1.Trailers}\n" +
                            $"Camion altura maxima: {camion1.AlturaMaxima}\n");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remolque remolque1 = new Remolque(4, "rojo");

            MessageBox.Show($"Remolque ruedas: {remolque1.ruedas}\n" +
                            $"Remolque color: {remolque1.color}\n");
        }
    }
}
