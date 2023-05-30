using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicSchema.Model
{
    public class CartRepository
    {
        private List<Cart> carts;

        public CartRepository()
        {
            // Initialize the list of carts with some mock data
            carts = new List<Cart>
            {
                new Cart
                {
                    Id = 1,
                    CreateDate = DateTime.Now.AddDays(-7),
                    UpdatedDate = DateTime.Now.AddDays(-2),
                    UserId = 1,
                    Articles = new List<Article>
                    {
                        new Article { Id = 1, Name = "Article 1", Price = 10.0m, Quantity = 2, Unit = "pcs" },
                        new Article { Id = 2, Name = "Article 2", Price = 5.0m, Quantity = 3, Unit = "pcs" }
                    },
                    Value = 35.0m
                },
                new Cart
                {
                    Id = 2,
                    CreateDate = DateTime.Now.AddDays(-3),
                    UpdatedDate = DateTime.Now.AddDays(-1),
                    UserId = 2,
                    Articles = new List<Article>
                    {
                        new Article { Id = 3, Name = "Article 3", Price = 7.5m, Quantity = 1, Unit = "kg" },
                        new Article { Id = 4, Name = "Article 4", Price = 2.0m, Quantity = 4, Unit = "pcs" }
                    },
                    Value = 15.0m
                }
            };
        }

        // Get a cart by ID
        public Cart GetCart(int id)
        {
            return carts.FirstOrDefault(c => c.Id == id);
        }

        // Get all carts with an updated date greater than or equal to the given date
        public List<Cart> GetAllCartsWithUpdateDate(DateTime date)
        {
            return carts.Where(c => c.UpdatedDate >= date).ToList();
        }

        // Get all carts
        public List<Cart> GetAllCarts()
        {
            return carts;
        }
    }
}
