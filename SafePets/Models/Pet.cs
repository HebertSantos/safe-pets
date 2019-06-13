using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SafePets.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Raça")]
        [Display(Name = "Raça")]
        public string Raca { get; set; }
        [Required(ErrorMessage = "Selecione o Sexo do Animal")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Preencha o campo Idade")]
        [Display(Name = "Idade")]
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
