using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ejercicio1.Models;
using Ejercicio1.HelperFunctions;

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Index(NumeroAInvertir numeroAInvertir)
        {
            if (ModelState.IsValid)
                return RedirectToAction("NInvertido", numeroAInvertir);            
            return View(numeroAInvertir);
        }

        public IActionResult NInvertido(NumeroAInvertir numeroAInvertir)
        {
            var numeroInvertido = new NumeroAInvertir { Numero = Helpers.InvertirNumero(numeroAInvertir.Numero) };

            return View(numeroInvertido);
        }

    }
}
