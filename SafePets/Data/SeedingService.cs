using SafePets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SafePets.Data
{
    public class SeedingService
    {
        private ApplicationDbContext _context;

        public SeedingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Pessoa.Any() ||
                _context.Pet.Any() ||
                _context.Adocao.Any())
            {
                return;
            }

            Pet p1 = new Pet('1', "Dogao", "Pintcher", 'M', "12anos");
            _context.Pet.AddRange(p1);

            _context.SaveChanges();
        }
    }
}
