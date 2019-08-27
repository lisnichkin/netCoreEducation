using System;
using System.Collections.Generic;
using System.Linq;

namespace WebStore.Models
{
    public class Cart
    {
        private List<CartLine> _lineCollection = new List<CartLine>();

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = _lineCollection
                .FirstOrDefault(p => p.Product.Id == product.Id);

            if (line == null)
            {
                _lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) =>
            _lineCollection.RemoveAll(l => l.Product.Id == product.Id);

        public virtual decimal ComputeTotalValue() =>
            _lineCollection.Sum(e => e.Product.Price * e.Quantity);

        public virtual void Clear() => _lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => _lineCollection;
    }
}
