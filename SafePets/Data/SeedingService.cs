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

            Pet p1 = new Pet('1', "Brutus", "Pintcher", "Macho", "12 anos");
            Pet p2 = new Pet('2', "Belinha", "Vira Lata", "Femea", "3 anos");
            Pet p3 = new Pet('3', "Mike", "Vira Lata", "Macho", "5 anos");
            Pet p4 = new Pet('4', "Rex", "Poodle", "Macho", "4 anos");
            Pet p5 = new Pet('5', "Mel", "Pitbull", "Femea", "5 anos");
            Pet p6 = new Pet('6', "Lolla", "Bulterrier", "Femea", "2 anos");
            Pet p7 = new Pet('7', "Polly", "Basset", "Femea", "1 ano");
            Pet p8 = new Pet('8', "Jack", "Cocker", "Macho", "2 anos");
            _context.Pet.AddRange(p1);
            _context.Pet.AddRange(p2);
            _context.Pet.AddRange(p3);
            _context.Pet.AddRange(p4);
            _context.Pet.AddRange(p5);
            _context.Pet.AddRange(p6);
            _context.Pet.AddRange(p7);
            _context.Pet.AddRange(p7);

            Pessoa p9 = new Pessoa('1', "405.873.388-81", "47.640.636-5", "Hebert Bueno dos Santos","hb-santos@hotmail.com", DateTime.Parse("2001-02-26"), "Rua Clorinda Cesaretti Moura", int.Parse("25"), "Romeu Santini", "SP", "São Carlos", "15566-500","(16) 99338-8188");
            Pessoa p10 = new Pessoa('2', "442.980.070-73", "48.219.382-7", "Marina Oliveira Araujo", "moaraujo@hotmail.com", DateTime.Parse("1967-08-11"), "Rua Tuiuti", int.Parse("1115"), "Iririú", "SC", "Joinville", "89227-470", "(47) 98749-6346");
            Pessoa p11 = new Pessoa('3', "011.200.020-79", "43.254.217-6", "Livia Costa Martins", "liv_martins@hotmail.com", DateTime.Parse("1975-10-05"), "Rua Caboclo Bernardo", int.Parse("413"), "Santa Cecília", "ES", "Colatina", "29700-370", "(27) 98386-8886");
            Pessoa p12 = new Pessoa('4', "041.872.570-55", "10.901.816-3", "Gabriel Cunha Correia", "gabscunha@hotmail.com", DateTime.Parse("2000-05-28"), "Travessa Ivete Vargas", int.Parse("894"), "Sussuarana", "BA", "Salvador", "41214-155", "(71) 98576-0372");
            Pessoa p13 = new Pessoa('5', "451.385.600-93", "31.241.242-3", "Bruna Goncalves Almeida", "bruna_goncalvesal@hotmail.com", DateTime.Parse("1999-12-31"), "Rua Nossa Senhora da Cabeça", int.Parse("145"), "Angelim", "PI", "Teresina", "64040-495", "(86) 98228-3230");
            Pessoa p14 = new Pessoa('6', "759.142.220-01", "24.476.224-7", "Kauan Barbosa Sousa", "kau_barbosa@hotmail.com", DateTime.Parse("1989-01-01"), "Travessa Bortolo Mangili", int.Parse("1352"), "Comerciário", "SC", "Criciúma", "88802-360", "(48) 98938-9847");
            Pessoa p15 = new Pessoa('7', "405.668.180-51", "42.171.678-2", "Julian Cavalcanti Correia", "juliancavalcanti@hotmail.com", DateTime.Parse("1992-09-13"), "Travessa Francisco Cavalcante de Moura", int.Parse("964"), "Alto do Sumaré", "RN", "Mossoró", "59633-800", "(84) 99666-9783");
            Pessoa p16 = new Pessoa('8', "460.806.510-68", "12.775.075-7", "Marisa Ribeiro Carvalho", "ribeiromarisa@hotmail.com", DateTime.Parse("1998-04-12"), "Rua Sergipe", int.Parse("145"), "Setor Urias Magalhães", "GO", "Goiânia", "74565-220", "(16) 99338-8188");
            Pessoa p17 = new Pessoa('9', "357.195.270-79", "12.091.595-9", "Caio Souza Rocha", "caio_sr@hotmail.com", DateTime.Parse("1994-05-25"), "Rua Herculano Ramos", int.Parse("187"), "Alecrim",  "SP", "São Carlos", "15575-500", "(16) 99384-9888");
            _context.Pessoa.AddRange(p9);
            _context.Pessoa.AddRange(p10);
            _context.Pessoa.AddRange(p11);
            _context.Pessoa.AddRange(p12);
            _context.Pessoa.AddRange(p13);
            _context.Pessoa.AddRange(p14);
            _context.Pessoa.AddRange(p15);
            _context.Pessoa.AddRange(p16);
            _context.Pessoa.AddRange(p17);
            _context.SaveChanges();
        }
    }
}
