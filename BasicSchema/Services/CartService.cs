using System.Collections.Generic;
using System.Linq;
using BasicSchema.Model;

namespace BasicSchema.Service
{
    public class CartService
    {
        private CartRepository repository;

        public CartService()
        {
            repository = new CartRepository();
        }

        // Get all carts and calculate the value of each cart
        public List<Cart> GetAllCarts()
        {
            List<Cart> carts = repository.GetAllCarts();

            foreach (Cart cart in carts)
            {
                decimal cartValue = 0.0m;

                foreach (Article article in cart.Articles)
                {
                    cartValue += article.Price * article.Quantity;
                }

                cart.Value = cartValue;
            }

            return carts;
        }
    }
}