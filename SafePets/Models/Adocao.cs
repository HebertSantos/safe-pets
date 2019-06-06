using SafePets.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SafePets.Models
{
    public class Adocao
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Data Adoção")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataAdocao { get; set; }
        public AdocaoStatus Status { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        public Pet Pet { get; set; }
        public int PetId { get; set; }

        public Adocao()
        {
        }

        public Adocao(int id, DateTime dataAdocao, AdocaoStatus status, Pessoa pessoa, Pet pet)
        {
            Id = id;
            DataAdocao = dataAdocao;
            Status = status;
            Pessoa = pessoa;
            Pet = pet;
        }
    }

}
