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

        public async Task<IActionResult> ConsultaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _adocoesService.FindByDateAsync(minDate,maxDate);
            return View(result);
        }

        public async Task<IActionResult> ConsultaAgrupada(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _adocoesService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }
    }

}