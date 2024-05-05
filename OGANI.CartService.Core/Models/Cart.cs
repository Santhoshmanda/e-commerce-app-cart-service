using System;
using System.Collections.Generic;

namespace OGANI.CartService.Domain.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int Quantity { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    //public virtual Product Product { get; set; } = null!;

    //public virtual UserProfile User { get; set; } = null!;
}
