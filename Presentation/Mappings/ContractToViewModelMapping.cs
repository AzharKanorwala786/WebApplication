using AutoMapper;
using DTO;
using Presentation.ViewModels;

namespace Presentation.Mappings
{
    public class ContractToViewModelMapping : Profile
    {
        public ContractToViewModelMapping()
        {
            CreateMap<Product, Product>();
            CreateMap<Category, CategoryVM>();
        }

        public override string ProfileName
        {
            get { return "ContractToViewModelMapping"; }
        }
    }
}