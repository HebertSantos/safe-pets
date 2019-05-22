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

        public void Insert (Pessoa obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Pessoa FindById (int id)
        {
            return _context.Pessoa.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove (int id)
        {
            var obj = _context.Pessoa.Find(id);
            _context.Pessoa.Remove(obj);
            _context.SaveChanges();
        }
    }
}