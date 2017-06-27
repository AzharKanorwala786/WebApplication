using System;
using AutoMapper;

namespace Presentation.Mappings
{
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