using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Entidades;
using Core.Interfaces;
using Core.Servicios;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEquipo _equipo;

        public HomeController(IEquipo equipo)
        {
            _equipo = equipo;
        }

        public IActionResult Index()
        {
            var equipoUno = new Equipo
            {
                idEquipo = 1,
                Nombre = "Submarino",
                Pais = "Argentina"
            };

            var equipoDos = new Equipo
            {
                idEquipo = 2,
                Nombre = "CruzDiablo",
                Pais = "Bolivia"
            };

            _equipo.AddEquipo(equipoUno);
            _equipo.AddEquipo(equipoDos);

            var test = _equipo.Get();
            var testDos = _equipo.GetByName("Submarino");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
