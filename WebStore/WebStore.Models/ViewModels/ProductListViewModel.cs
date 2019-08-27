using System.Collections.Generic;


namespace WebStore.Models.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
