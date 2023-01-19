using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nombre_WindowsEFDatos.Models;
using static nombre_WindowsEFDatos.Dac.AdminAvion;
using nombre_WindowsEFDatos.Dac;

namespace nombre_WindowsEFDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LineaAerea lineaerea1 = new LineaAerea()
            { 
                Nombre = "Aerolineas",
                FechaInicioActividades = new DateTime(2023,01,24)
            };
                
            Avion avion1 = new Avion()
            {
                Capacidad= 500,
                Denominacion = "hola",
                LineaAerea = lineaerea1
            };

            int filasAfectadas = AdminAvion.Insert(avion1);

            if (filasAfectadas > 0)
            {

                MessageBox.Show($"Se ha Insertado Alumno {avion1.Capacidad} {avion1.Denominacion}");

            }
        }
    }
}
