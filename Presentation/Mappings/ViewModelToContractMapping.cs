using AutoMapper;
using DTO;
using Presentation.ViewModels;

namespace Presentation.Mappings
{
    public class ViewModelToContractMapping : Profile
    {
        public ViewModelToContractMapping()
        {

            CreateMap<ProductFormVM, Product>()
                     .ForMember(p => p.Name, map => map.MapFrom(vm => vm.Name))
                     .ForMember(p => p.Description, map => map.MapFrom(vm => vm.Description))
                     .ForMember(p => p.Price, map => map.MapFrom(vm => vm.Price))
                     .ForMember(p => p.Image, map => map.MapFrom(vm => vm.File.FileName))
                     .ForMember(p => p.CategoryId, map => map.MapFrom(vm => vm.CategoryId));
        }

        public override string ProfileName
        {
            get { return "ViewModelToContractMapping"; }
        }
    }
}