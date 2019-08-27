using System.Collections.Generic;
using WebStore.DataAccess.Entities;

namespace WebStore.DataAccess.Repository
{
    public interface IProductRepository
    {
        List<Product> Get();
    }
}
