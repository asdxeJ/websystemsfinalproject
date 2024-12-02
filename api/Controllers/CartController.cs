using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepo;
        public CartController(ICartRepository cartRepos)
        {
            _cartRepo = cartRepos;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cart = await _cartRepo.GetAllAsync();
            return Ok(cart);
        }
    }
}