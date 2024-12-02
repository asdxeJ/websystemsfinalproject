using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;

namespace api.Interfaces
{
    public interface ICartRepository
    {
        Task<List<Cart>> GetAllAsync();
    }
}