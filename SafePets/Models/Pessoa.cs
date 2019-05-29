using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SafePets.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Display(Name = "RG")]
        public string Rg { get; set; }

        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        public string Endereco  { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
        public ICollection<Adocao> Adocoes { get; set; } = new List<Adocao>();

        public Pessoa()
        {
        }

        public Pessoa(int id, string cpf, string rg, string nome, string email, DateTime dataNascimento, string endereco, string bairro, string estado, string cidade,string cep, string telefone)
        {
            Id = id;
            Cpf = cpf;
            Rg = rg;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Bairro = bairro;
            Estado = estado;
            Cidade = cidade;
            Cep = cep;
            Telefone = telefone;
        }

        public void AddAdocao (Adocao ad)
        {
            Adocoes.Add(ad);
        }

        public void RemoveAdocao (Adocao ad)
        {
            Adocoes.Remove(ad);
        }


    }
}
