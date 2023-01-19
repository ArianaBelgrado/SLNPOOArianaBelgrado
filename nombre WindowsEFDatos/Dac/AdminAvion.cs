using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nombre_WindowsEFDatos.Data;
using nombre_WindowsEFDatos.Models;

namespace nombre_WindowsEFDatos.Dac
{

        public static class AdminAvion
        {
            private static DBAvionContext context = new DBAvionContext();

            public static List<Avion> SelectAll()
            {
                return context.Aviones.ToList();
            }

            public static Avion SelectWhereById(int id)
            {
                return context.Aviones.Find(id);
            }

            public static int Insert(Avion avion)
            {
                context.Aviones.Add(avion);
                return context.SaveChanges();
            }

            public static int Update(Avion avion)
            {
                Avion avionDeOrigen = context.Aviones.Find(avion.IdAvion);

                avionDeOrigen.IdAvion = avion.IdAvion;
                avionDeOrigen.Capacidad = avion.Capacidad;
                avionDeOrigen.Denominacion = avion.Denominacion;



                return context.SaveChanges();
            }

            public static int Delete(Avion avion)
            {
                Avion avionDeOrigen = context.Aviones.Find(avion.IdAvion);

                if (avionDeOrigen != null)
                {
                    context.Aviones.Remove(avionDeOrigen);
                    return context.SaveChanges();
                }

                return 0;
            }
        }
    }

