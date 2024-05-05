using System;
using AutoMapper;
using OGANI.CartService.Domain.Interfaces;
using OGANI.CartService.Domain.Models;
using OGANI.CartService.Infrastructure.Persistance;

namespace OGANI.CartService.Infrastructure.Repositories
{
	public class WishlistRepository : IWishlistRepository
    {
        private readonly OganiDbContext _oganiDbContext;
        private readonly IMapper _mapper;
        public WishlistRepository(OganiDbContext oganiDbContext, IMapper mapper)
		{
            _oganiDbContext = oganiDbContext;
            _mapper = mapper;
        }

        public Task<Wishlist> AddToWishlistAsync(Wishlist wishlist, string adObjId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesProductExistAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Wishlist?> GetWishlistByIdAsync(int wishlistId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Wishlist>> GetWishlistByUserIdAsync(string adObjId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsWishlistIdValidAsync(int wishlistId, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsWishlistIdValidAsync(int wishlistId, string adObjId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveFromWishlistAsync(int wishlistId)
        {
            throw new NotImplementedException();
        }

        public Task<Wishlist> UpdateWishlistAsync(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }
    }
}

