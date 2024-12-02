using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDBContext _context;
        public CartRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Cart> CreateAsync(Cart cartModel)
        {
            await _context.Carts.AddAsync(cartModel);
            await _context.SaveChangesAsync();
            return cartModel;
        }

        public async Task<List<Cart>> GetAllAsync()
        {
            // to include the details of the menu item from cart
            return await _context.Carts.Include(c => c.Menu).ToListAsync();
        }

        public async Task<Cart?> GetByIdAsync(int id)
        {
            // fetch cart by id with its related menu item
            return await _context.Carts
                .Include(c => c.Menu)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}