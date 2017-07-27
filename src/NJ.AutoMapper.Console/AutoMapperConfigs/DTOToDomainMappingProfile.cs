using AutoMapper;
using NJ.AutoMapper.Console.Domain;
using NJ.AutoMapper.Console.DTO;

namespace NJ.AutoMapper.Console.AutoMapperConfigs
{
    public class DTOToDomainMappingProfile : Profile
    {
        public DTOToDomainMappingProfile()
        {
            CreateMap<PessoaDTO, Pessoa>();
            CreateMap<ContatoDTO, Contato>();

            CreateMap<EnderecoDTO, Endereco>().
                ForMember(destino => destino.Logradouro, origem => origem.MapFrom(map => map.LogradouroEndereco))
                .ForMember(destino => destino.Numero, origem => origem.MapFrom(map => map.NumeroEndereco))
                .ForMember(destino => destino.Bairro, origem => origem.MapFrom(map => map.BairroEndereco))
                .ForMember(destino => destino.Cidade, origem => origem.MapFrom(map => map.CidadeEndereco));
        }
    }

    
}