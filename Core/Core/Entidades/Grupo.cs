using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entidades
{
    public class Grupo
    {
        #region Atributos
        //Atributos
        public int idGrupo { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Metodos
        //Metodos
        public override string ToString()
        {
            return
                "IdGrupo: " + this.idGrupo.ToString() + "" +
                "\nNombre: " + this.Nombre;
        }
        #endregion
    }
}
