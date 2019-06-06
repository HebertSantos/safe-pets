using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SafePets.Data;
using SafePets.Models;
using SafePets.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace SafePets.Services
{
    public class AdocaoService
    {
        private readonly ApplicationDbContext _context;

        public AdocaoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Adocao>> FindAllAsync()
        {
            return await _context.Adocao.ToListAsync();
        }
        public async Task InsertAsync(Adocao obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Adocao> FindByIdAsync(int id)
        {
            return await _context.Adocao.Include(obj => obj.Pet).Include(obj => obj.Pessoa).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Adocao.FindAsync(id);
            _context.Adocao.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Adocao obj)
        {
            bool hasAny = await _context.Adocao.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}