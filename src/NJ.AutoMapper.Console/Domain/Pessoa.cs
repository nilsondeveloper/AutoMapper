using System;
using System.Collections.Generic;

namespace NJ.AutoMapper.Console.Domain
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Contato> Contatos { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}