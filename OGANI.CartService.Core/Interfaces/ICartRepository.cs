using System;
using OGANI.CartService.Domain.Models;

namespace OGANI.CartService.Domain.Interfaces
{
	public interface ICartRepository
	{
        Task<Cart> GetCartByIdAsync(int cartId);
        Task<List<Cart>> GetCartsByUserIdAsync(int  userId);
        Task<Cart> AddToCartAsync(Cart cart, int userId);
        Task<Cart> UpdateCartAsync(Cart cart);
        Task<bool> RemoveFromCartAsync(int cartId);
        Task<bool> IsCartIdValidAsync(int cartId, string adObjId);
        //Task<Product?> GetProductByIdAsync(int productId);

    }
}

