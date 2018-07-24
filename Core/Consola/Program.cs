using Core.Entidades;
using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ju = new Jugador();
            var test = ju.DarOtroAnuncio();
            var mi = (Miembro)ju;
            var test2 = mi.DarOtroAnuncio();
        }
    }
}
