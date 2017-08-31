namespace API.AutoMapperConfig
{
    using AutoMapper;
    using DataAccess.Mapping;

    public static class AutoMapperConfig
    {
        public static IMapper BuildMaps()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ModelToEntityMapping>();
                cfg.AddProfile<EntityToModelMapping>();
            });
            return config.CreateMapper();
        }
    }
}