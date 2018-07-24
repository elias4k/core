using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entidades
{
    public class Jugador: Miembro
    {
        //public Jugador(DateTime fechaNac):base(fechaNac){}
        public string posicion { get; set; }
        public int goles { get; set; }
        public int asistencias { get; set; }
        public int Amonestaciones { get; set; }
        public int Expulsiones { get; set; }

        public new string DarOtroAnuncio()
        {
            return "noemo";
        } 
            
    }
}
