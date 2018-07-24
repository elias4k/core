using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entidades
{
    public abstract class Miembro
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int? Edad => FechaNacimiento != null ? (DateTime.Today.Year - FechaNacimiento.Year) as int? : null;
        //public int EdadDos { get { return FechaNacimiento != null ? (DateTime.Today.Year - FechaNacimiento.Year) : 0; } }

        public virtual string DarAnuncio()
        {
            return "Hola";
        }

        public string DarOtroAnuncio() {
            return "chau";
        }
        
    }
}
