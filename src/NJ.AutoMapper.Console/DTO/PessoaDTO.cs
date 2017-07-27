using System;
using System.Collections.Generic;

namespace NJ.AutoMapper.Console.DTO
{
    public class PessoaDTO
    {
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<ContatoDTO> Contatos { get; set; }
        public List<EnderecoDTO> Enderecos { get; set; }
    }
}