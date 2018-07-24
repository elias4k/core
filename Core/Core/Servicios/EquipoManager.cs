using Core.Data;
using Core.Entidades;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Servicios
{
    public class EquipoManager: IEquipo
    {
        public List<Equipo> Get()
        {
            return Db.Equipos;
        }

        public Equipo GetByName(string nombre)
        {
            return Get().Where(x => x.Nombre.Equals(nombre)).FirstOrDefault();
        }

        public bool AddEquipo(Equipo equipo)
        {
            var result = true;
            try
            {
                if(Db.Equipos == null)
                {
                    Db.Equipos = new List<Equipo> { equipo };
                }
                else
                {
                    Db.Equipos.Add(equipo);
                }
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

    }
}
