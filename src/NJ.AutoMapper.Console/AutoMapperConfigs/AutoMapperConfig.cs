using AutoMapper;

namespace NJ.AutoMapper.Console.AutoMapperConfigs
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToDTOMappingProfile>();
                x.AddProfile<DTOToDomainMappingProfile>();
            });
        } 
    }
}