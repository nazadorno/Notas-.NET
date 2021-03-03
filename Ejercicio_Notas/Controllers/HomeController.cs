using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ejercicio_Notas.Models;

namespace Ejercicio_Notas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NotasContextBd db;

        public HomeController(ILogger<HomeController> logger, NotasContextBd contexto) {
            this._logger = logger;
            this.db = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Notas()
        {
            return View();
        }

        public IActionResult MisNotas(){
            ViewBag.MisNotas = db.Nota.ToList();            
            return View();
        }

         public JsonResult ConsultarNotas()
        {
            return Json(db.Nota.ToList());
        }

        [HttpPost]
        public IActionResult GuardarNota(string titulo, string cuerpo)
        {
            Nota nuevaNota = new Nota{
                Titulo = titulo,
                Cuerpo = cuerpo
            };

            db.Nota.Add(nuevaNota);
            db.SaveChanges();
            return View("Notas");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
