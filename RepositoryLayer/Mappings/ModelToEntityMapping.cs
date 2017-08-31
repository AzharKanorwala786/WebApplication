namespace DataAccess.Mapping
{
   using AutoMapper;

    public class ModelToEntityMapping : Profile
    {
        public ModelToEntityMapping()
        {
            CreateMap<Contracts.Product, Entities.Product>();
            CreateMap<Contracts.Category, Entities.Category>();
        }

        public override string ProfileName
        {
            get { return "ModelToEntityMapping"; }
        }
    }
 }
