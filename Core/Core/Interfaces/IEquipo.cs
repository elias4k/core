using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IEquipo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Equipo> Get();

        /// <summary>
        /// Get Equipo by Name
        /// </summary>
        /// <param nombre="nombre">Name of Equipo</param>
        /// <returns></returns>
        Equipo GetByName(string nombre);

        /// <summary>
        /// Add new Equipo
        /// </summary>
        /// <param name="equipo"></param>
        /// <returns></returns>
        bool AddEquipo(Equipo equipo);
    }
}
