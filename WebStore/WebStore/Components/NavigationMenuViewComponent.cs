using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Contracts;
using WebStore.Models;

namespace WebStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IProductManager _productManager;

        public NavigationMenuViewComponent(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_productManager.Get().Select(x=>x.Category).Distinct().OrderBy(x=>x).ToList());
        }
    }
}
