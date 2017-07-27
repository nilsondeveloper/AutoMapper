using AutoMapper;
using NJ.AutoMapper.Console.Domain;
using NJ.AutoMapper.Console.DTO;

namespace NJ.AutoMapper.Console.AutoMapperConfigs
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Pessoa, PessoaDTO>();
            CreateMap<Contato, ContatoDTO>();

            CreateMap<Endereco, EnderecoDTO>()
                .ForMember(destino => destino.LogradouroEndereco, origem => origem.MapFrom(map => map.Logradouro))
                .ForMember(destino => destino.NumeroEndereco, origem => origem.MapFrom(map => map.Numero))
                .ForMember(destino => destino.BairroEndereco, origem => origem.MapFrom(map => map.Bairro))
                .ForMember(destino => destino.CidadeEndereco, origem => origem.MapFrom(map => map.Cidade));
        }
    }


}