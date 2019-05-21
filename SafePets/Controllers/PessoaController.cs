using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SafePets.Services;

namespace SafePets.Controllers
{
    public class PessoaController : Controller
    {

        private readonly PessoaService _pessoaService;

        public PessoaController (PessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }


        public IActionResult Index()
        {
            var list = _pessoaService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}