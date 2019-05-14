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
        public ICollection<Adocao> Adocoes { get; set; } = new List<Adocao>();

        public Pet()
        {

        }

        public Pet(int id, string nome, string raca, char sexo, string idade, byte[] imagem)
        {
            Id = id;
            Nome = nome;
            Raca = raca;
            Sexo = sexo;
            Idade = idade;
            Imagem = imagem;
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
