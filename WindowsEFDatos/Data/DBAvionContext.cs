using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Data
{
    internal class DBAvionContext : DbContext
    {
        //Constructor
        public DBAvionContext() : base("KeyDB") { }

        //Propiedades DBSET
        public DbSet<LineaAerea> LineaAereas { get; set; }
        public Avion Avion { get; set; }
    }
}
