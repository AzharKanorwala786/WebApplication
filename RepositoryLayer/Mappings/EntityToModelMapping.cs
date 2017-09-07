using AutoMapper;

namespace DataAccess.Mapping
{
  public class EntityToModelMapping : Profile
    {
        public EntityToModelMapping()
        {
            CreateMap<Entities.Category, Contracts.Category>();
            CreateMap<Entities.Product, Contracts.Product>().ForMember(src => src.Category, opts => opts.MapFrom(dest => dest.Category.Name));        
        }

        public override string ProfileName
        {
            get { return "EntityToModelMapping"; }
        }
    }
}
