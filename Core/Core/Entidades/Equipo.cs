using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entidades
{

    //Atributos
    public class Equipo
    {
        #region Atributos
        public int idEquipo { get; set; }
        public string Pais { get; set; }
        public string Abreviatura { get; set; }
        public string Nombre { get; set; }
        #endregion

        /*#region Constructores
        //Constructores
        public Equipo()
        {
            this.idEquipo = 0;
            this.Pais = string.Empty;
        }

        public Equipo(int p_idEquipo)
        {
            this.idEquipo = p_idEquipo;
            this.Pais = string.Empty;
        }

        public Equipo(int p_idEquipo, string p_Pais)
        {
            this.idEquipo = p_idEquipo;
            this.Pais = p_Pais;
        }
        #endregion*/

        #region Metodos
        //Metodos

        public override string ToString()
        {
            return
                "IdEquipo: " + this.idEquipo.ToString() + "" +
                "\nPais: " + this.Pais;
        }
        #endregion

    }


}
