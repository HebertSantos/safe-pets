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
    public class FindFree
    {
        private readonly ApplicationDbContext _context;

        public FindFree(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pet>> FindAllAsync()
        {
            return await _context.Pet.ToListAsync();
        }

        public List<Pet> GetPets()
        {
            var subselect = (from b in _context.Adocao select b.PetId).ToList();
            var result = from c in _context.Pet where !subselect.Contains(c.Id) select c;
            return result.ToList();
        }

        public async Task InsertAsync(Pet obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Pet> FindByIdAsync(int id)
        {
            return await _context.Pet.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Pet.FindAsync(id);
                _context.Pet.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não posso deletar o Pet pois já possui adoção");
            }
        }

        public async Task UpdateAsync(Pet obj)
        {
            bool hasAny = await _context.Pet.AnyAsync(x => x.Id == obj.Id);
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

