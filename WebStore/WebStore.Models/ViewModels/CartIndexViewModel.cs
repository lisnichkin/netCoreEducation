using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
