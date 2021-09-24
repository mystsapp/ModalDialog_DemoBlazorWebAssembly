using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class CartService : ICartService
    {
        public CartService()
        {
            Cart = new List<Product>();
        }

        public IList<Product> Cart { get; private set; }

        public int Total { get; set; }

        public event Action OnChange; // OnChange dung de giu trang thai ==> AppState -> for shoping cart's state

        public void AddProduct(Product product)
        {
            Cart.Add(product);
            Total += product.Price;
            NotifyStateChanged(); // to invoke OnChang()
        }

        public void DeleteProduct(Product product)
        {
            Cart.Remove(product);
            Total -= product.Price;
            NotifyStateChanged(); // to invoke OnChang()
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}