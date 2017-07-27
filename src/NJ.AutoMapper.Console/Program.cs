using System;
using System.Collections.Generic;
using AutoMapper;
using NJ.AutoMapper.Console.AutoMapperConfigs;
using NJ.AutoMapper.Console.Domain;
using NJ.AutoMapper.Console.DTO;

namespace NJ.AutoMapper.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfig.RegisterMappings();

            var pessoa = new Pessoa
            {
                Nome = "Nilson Júnior",
                DataNascimento = new DateTime(1989, 03, 28),
                Contatos = new List<Contato>
                {
                    new Contato() {Nome = "Celular", Telefone = "988640000"},
                    new Contato() {Nome = "Fixo", Telefone = "34620000"}
                },
                Enderecos = new List<Endereco>()
                {
                    new Endereco(){Logradouro = "Av Boa Viagem", Numero = "292", Bairro = "Boa Viagem", Cidade = "Recife"}
                }
            };
         
            // Pessoa to PessoaDTO 
            PessoaDTO pessoaDTOFromPessoa = Mapper.Map<Pessoa, PessoaDTO>(pessoa);

            // PessoaDTO to Pessoa
            Pessoa pessoaFromPessoaDTO = Mapper.Map<PessoaDTO, Pessoa>(pessoaDTOFromPessoa);
        }
    }
}
