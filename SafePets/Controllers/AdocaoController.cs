using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SafePets.Models;
using SafePets.Models.ViewModel;
using SafePets.Services;
using SafePets.Services.Exceptions;
using System.Diagnostics;

namespace SafePets.Controllers
{
    public class AdocaoController : Controller
    {
        private readonly AdocaoService _adocaoService;
        private readonly PessoaService _pessoaService;
        private readonly FindFree _petService;

        public AdocaoController(AdocaoService adocaoService, PessoaService pessoaService, FindFree petService)
        {
            _adocaoService = adocaoService;
            _pessoaService = pessoaService;
            _petService = petService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _adocaoService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var pessoas =  await _pessoaService.FindAllAsync();
            var pets = _petService.GetPets();
            var viewModel = new AdocaoFormViewModel { Pessoas = pessoas, Pets = pets };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Adocao adocao)
        {
            if (!ModelState.IsValid)
            {
                var pessoas = await _pessoaService.FindAllAsync();
                var pets =  _petService.GetPets();
                var viewModel = new AdocaoFormViewModel { Adocao = adocao, Pessoas = pessoas, Pets = pets };
                return View(viewModel);
            }
            await _adocaoService.InsertAsync(adocao);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _adocaoService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            { 
                await _adocaoService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _adocaoService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _adocaoService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            List<Pessoa> pessoas = await _pessoaService.FindAllAsync();
            List<Pet> pets = await _petService.FindAllAsync();
            AdocaoFormViewModel viewModel = new AdocaoFormViewModel {Adocao = obj, Pessoas = pessoas, Pets = pets };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Adocao adocao)
        {
            if (!ModelState.IsValid)
            {
                var pessoas = await _pessoaService.FindAllAsync();
                var pets =  await _petService.FindAllAsync();
                var viewModel = new AdocaoFormViewModel { Adocao = adocao, Pessoas = pessoas, Pets = pets };
                return View(viewModel);
            }
            if (id != adocao.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                await _adocaoService.UpdateAsync(adocao);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
