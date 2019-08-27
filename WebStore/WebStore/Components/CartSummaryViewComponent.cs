﻿using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private  readonly Cart _cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            _cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
