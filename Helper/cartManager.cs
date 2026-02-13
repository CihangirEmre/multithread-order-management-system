using ManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentApplication.Helper
{
    public class CartManager
    {
        public List<CartItem> Items { get; private set; } = new List<CartItem>();

        public void AddToCart(Product product, int quantity)
        {
            var existingItem = Items.FirstOrDefault(x => x.Product.ProductID == product.ProductID);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity; 
            }
            else
            {
                Items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public void RemoveFromCart(int productId)
        {
            Items.RemoveAll(x => x.Product.ProductID == productId);
        }

        public decimal CalculateTotalPrice()
        {
            return Items.Sum(x => x.TotalPrice);
        }

        public CartItem GetItemByProductId(int productId)
        {
            return Items.FirstOrDefault(x => x.Product.ProductID == productId);
        }
    }

}
