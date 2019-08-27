using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.DataAccess.Entities;

namespace WebStore.DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebStoreContext _dbContext;

        public ProductRepository()
        {
            _dbContext = new WebStoreContext();
        }

        public List<Product> Get()
        {
            return _dbContext.Products.ToList();
        }
    }
}
