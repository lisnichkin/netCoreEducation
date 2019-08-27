using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebStore.Contracts;
using WebStore.DataAccess.Repository;
using Product = WebStore.Models.Product;

namespace WebStore.Domain
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductManager(IMapper mapper)
        {
            _repository = new ProductRepository();
            _mapper = mapper;
        }

        public List<Product> Get()
        {
            var products = _repository.Get();

            List<Product> newListProducts = products.Select(x=> _mapper.Map<Product>(x)).OrderBy(x=>x.Id).ToList();

            return newListProducts;
        }
    }
}
