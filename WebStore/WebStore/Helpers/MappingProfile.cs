using AutoMapper;
using Product = WebStore.Models.Product;

namespace WebStore.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DataAccess.Entities.Product, Product>();
        }
    }
}
