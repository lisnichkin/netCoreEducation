using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Contracts;
using WebStore.Models;
using WebStore.Models.ViewModels;

namespace WebStore.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductManager _productManager;
        private readonly Cart _cart;

        public CartController(IProductManager productManager, Cart cartService)
        {
            _productManager = productManager;
            _cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = _cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(Guid id, string returnUrl)
        {
            Product product = _productManager.Get()
                .FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                _cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(Guid productId,
            string returnUrl)
        {
            Product product = _productManager.Get()
                .FirstOrDefault(p => p.Id == productId);

            if (product != null)
            {
                _cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}