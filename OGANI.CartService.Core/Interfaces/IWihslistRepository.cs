using System;
using OGANI.CartService.Domain.Models;

namespace OGANI.CartService.Domain.Interfaces
{
	public interface IWishlistRepository
	{

        Task<Wishlist?> GetWishlistByIdAsync(int wishlistId);
        Task<IEnumerable<Wishlist>> GetWishlistByUserIdAsync(string adObjId);
        Task<Wishlist> AddToWishlistAsync(Wishlist wishlist, string adObjId);
        Task<Wishlist> UpdateWishlistAsync(Wishlist wishlist);
        Task<bool> RemoveFromWishlistAsync(int wishlistId);
        Task<bool> IsWishlistIdValidAsync(int wishlistId, int userId);
        Task<bool> IsWishlistIdValidAsync(int wishlistId, string adObjId);
        Task<bool> DoesProductExistAsync(int productId);
    }
}

