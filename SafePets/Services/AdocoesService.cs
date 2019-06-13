using Microsoft.EntityFrameworkCore;
using SafePets.Data;
using SafePets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafePets.Services
{
    public class AdocoesService
    {
        private readonly ApplicationDbContext _context;

        public AdocoesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Adocao>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Adocao select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataAdocao >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataAdocao <= maxDate.Value);
            }
            return await result
                .Include(x => x.Pessoa)
                .Include(x => x.Pet)
                .OrderByDescending(x => x.DataAdocao)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Pessoa, Adocao>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Adocao select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataAdocao >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataAdocao <= maxDate.Value);
            }
            return await result
                .Include(x => x.Pessoa)
                .Include(x => x.Pet)
                .OrderByDescending(x => x.DataAdocao)
                .GroupBy(x => x.Pessoa)
                .ToListAsync();
        }
    }
}

    
