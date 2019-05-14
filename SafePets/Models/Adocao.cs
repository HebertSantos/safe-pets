using SafePets.Models.Enums;
using System;

namespace SafePets.Models
{
    public class Adocao
    {
        public int Id { get; set; }
        public DateTime DataAdocao { get; set; }
        public AdocaoStatus Status { get; set; }
        public Pessoa Pessoa { get; set; }
        public Pet Pet { get; set; }

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
