using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BasicSchema.Model;
using BasicSchema.Service;

namespace BasicSchema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private CartService service;

        public CartController()
        {
            service = new CartService();
        }

        [HttpGet]
        public List<Cart> GetAllCarts()
        {
            return service.GetAllCarts();
        }
    }
}