using System.Collections.Generic;
using WebStore.Models;


namespace WebStore.Contracts
{
    public interface IProductManager
    {
        List<Product> Get();
    }
}
