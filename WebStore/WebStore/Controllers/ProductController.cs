using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Contracts;
using WebStore.Models.ViewModels;

namespace WebStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager _productManager;

        public int PageSize = 2;

        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public ViewResult List(string category,int pageNumber)
        {
            var products = _productManager.Get();

            return View(new ProductListViewModel
            {
                Products = products.Where(x=> category == null || x.Category == category).Skip((pageNumber - 1) * PageSize).Take(PageSize).ToList(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? products.Count : products.Count(x => x.Category == category)
                },
                CurrentCategory = category
            });
        }

    }
}