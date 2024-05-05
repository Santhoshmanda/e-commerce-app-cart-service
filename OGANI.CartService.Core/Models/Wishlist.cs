namespace OGANI.CartService.Domain.Models;

public partial class Wishlist
{
    public int WishlistId { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    //public virtual Product Product { get; set; } = null!;

    //public virtual UserProfile User { get; set; } = null!;
}
