using System;
using AutoMapper;
using OGANI.CartService.Domain.Interfaces;
using OGANI.CartService.Domain.Models;
using OGANI.CartService.Infrastructure.Persistance;

namespace OGANI.CartService.Infrastructure.Repositories
{
	public class CartRepository : ICartRepository
    {
        private readonly OganiDbContext _oganiDbContext;
        private readonly IMapper _mapper;
		public CartRepository(OganiDbContext oganiDbContext, IMapper mapper)
		{
            _oganiDbContext = oganiDbContext;
            _mapper = mapper;
		}

        public Task<Cart> AddToCartAsync(Cart cart, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetCartByIdAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cart>> GetCartsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsCartIdValidAsync(int cartId, string adObjId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveFromCartAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> UpdateCartAsync(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}

