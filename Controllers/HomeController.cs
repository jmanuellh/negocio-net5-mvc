using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using negocio_net5_mvc.Models;

namespace negocio_net5_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NegocioContext _context;

        public HomeController(ILogger<HomeController> logger, NegocioContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
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

        public async Task<IActionResult> Tabla()
        {
            // IEnumerable<Models.Home.Persona> model = new List<Models.Home.Persona>() {
            //     new Models.Home.Persona {Id = 1, Nombre = "Pedro"}
            // };
            // var personas = new PersonasController(_context);
            // var model = await personas.GetPersonasB();
            // Console.WriteLine(model.GetType());
            
            var model = await _context.Personas.ToListAsync();
            
            return PartialView("_Tabla", model);
            // return Ok();
        }
    }
}
