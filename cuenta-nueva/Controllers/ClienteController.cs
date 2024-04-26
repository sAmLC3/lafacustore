using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mymovieapp.Models;

namespace mymovieapp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Nombre,Apellido,CorreoElectronico,Telefono,FechaNacimiento")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = "El cliente se ha registrado";
                if(cliente.Nombre.Equals("Juan") && cliente.Apellido.Equals("Perez") ){
                    ViewData["Message"] = "El cliente Juan ud tiene un saldo de 5000";
                }
                return View("Index");
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}