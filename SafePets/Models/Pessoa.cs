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
        [Required(ErrorMessage = "Preencha o campo CPF")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Preencha o campo RG")]
        [Display(Name = "RG")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de 2 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [Display(Name ="E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha a Data de Nascimento")]
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Preencha o Endereço")]
        public string Endereco  { get; set; }
        [Required(ErrorMessage = "Preencha o campo Numero")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Preencha o Bairro")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Preencha o campo Estado")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Preencha o campo Cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Preencha o campo Cep")]
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Preencha o campo Telefone")]
        public string Telefone { get; set; }
        public ICollection<Adocao> Adocoes { get; set; } = new List<Adocao>();

        public Pessoa()
        {
        }

        public Pessoa(int id, string cpf, string rg, string nome, string email, DateTime dataNascimento, string endereco, int numero, string bairro, string estado, string cidade,string cep, string telefone)
        {
            Id = id;
            Cpf = cpf;
            Rg = rg;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Numero = numero;
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
