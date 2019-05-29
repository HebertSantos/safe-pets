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
        public string Sexo { get; set; }
        public string Idade { get; set; }
        public ICollection<Adocao> Adocoes { get; set; } = new List<Adocao>();

        public Pet()
        {

        }

        public Pet(int id, string nome, string raca, string sexo, string idade)
        {
            Id = id;
            Nome = nome;
            Raca = raca;
            Sexo = sexo;
            Idade = idade;
            
        }
        public void AddAdocao(Adocao ad)
        {
            Adocoes.Add(ad);
        }

        public void RemoveAdocao(Adocao ad)
        {
            Adocoes.Remove(ad);
        }
    }

   
}
