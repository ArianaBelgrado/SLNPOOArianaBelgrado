using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nombre_WindowsEFDatos.Models;

namespace nombre_WindowsEFDatos.Data
{
    internal class DBAvionContext : DbContext
    {
        // Constructor
        public DBAvionContext() : base("KeyDB") { }

        // Propiedades DBSet
        public DbSet<Avion> Aviones { get; set; }
        public DbSet<LineaAerea> LineaAereas { get; set; } 
    }
}
