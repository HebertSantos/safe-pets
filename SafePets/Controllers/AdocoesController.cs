using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SafePets.Controllers
{
    public class AdocoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConsultaSimples()
        {
            return View();
        }

        public IActionResult ConsultaAgrupada()
        {
            return View();
        }
    }

}