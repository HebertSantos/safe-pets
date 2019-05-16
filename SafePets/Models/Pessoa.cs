﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafePets.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco  { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public ICollection<Adocao> Adocoes { get; set; } = new List<Adocao>();

        public Pessoa()
        {
        }

        public Pessoa(int id, string cpf, string rg, string nome, DateTime dataNascimento, string endereco, string bairro, string estado, string cidade)
        {
            Id = id;
            Cpf = cpf;
            Rg = rg;
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Bairro = bairro;
            Estado = estado;
            Cidade = cidade;

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