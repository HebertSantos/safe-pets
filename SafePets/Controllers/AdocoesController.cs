using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SafePets.Services;
namespace SafePets.Controllers
{
    public class AdocoesController : Controller
    {
        private readonly AdocoesService _adocoesService;

        public AdocoesController(AdocoesService adocoesService)
        {
            _adocoesService = adocoesService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ConsultaSimples(DateTime? minDate, DateTime maxDate)
        {
            var result = await _adocoesService.FindByDateAsync(minDate,maxDate);
            return View(result);
        }

        public IActionResult ConsultaAgrupada()
        {
            return View();
        }
    }

}