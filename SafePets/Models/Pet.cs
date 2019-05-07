using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafePets.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public char Sexo { get; set; }
        public string Idade { get; set; }
        public byte[] Imagem { get; set; }
    }
}
