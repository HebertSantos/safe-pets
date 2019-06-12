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
    public class PessoaService
    {
        private readonly ApplicationDbContext _context;

        public PessoaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pessoa>> FindAllAsync()
        {
            return await _context.Pessoa.ToListAsync();
        }

        public async Task InsertAsync (Pessoa obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Pessoa> FindByIdAsync (int id)
        {
             return await _context.Pessoa.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async  Task RemoveAsync (int id)
        {
            try
            {
                var obj = await _context.Pessoa.FindAsync(id);
                _context.Pessoa.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não pode deletar a Pessoa pois há adoções vinculadas");
            }
            
        }

        public async Task UpdateAsync(Pessoa obj)
        {
            bool hasAny = await _context.Pessoa.AnyAsync(x => x.Id == obj.Id);
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