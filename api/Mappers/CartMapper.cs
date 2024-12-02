using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Cart;
using api.Model;

namespace api.Mappers
{
    public static class CartMapper
    {
        public static CartDTO ToCartDTO(this Cart cartModel)
        {
            return new CartDTO
            {
                Id = cartModel.Id,
                CustomerId = cartModel.CustomerId,
                MenuId = cartModel.MenuId,
                Quantity = cartModel.Quantity,
            };
        }
    }
}