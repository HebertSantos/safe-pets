using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SafePets.Data;
using SafePets.Models;

namespace SafePets.Services
{
    public class PessoaService
    {
        private readonly ApplicationDbContext _context;

        public PessoaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Pessoa> FindAll()
        {
            return _context.Pessoa.ToList();
        }

    }
}