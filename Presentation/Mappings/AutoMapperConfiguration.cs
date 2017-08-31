namespace Presentation.Mappings
{
    using AutoMapper;
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ContractToViewModelMapping>();
                x.AddProfile<ViewModelToContractMapping>();
            });
        }
    }
}