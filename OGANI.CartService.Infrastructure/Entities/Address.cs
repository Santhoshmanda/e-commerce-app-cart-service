using System;
using System.Collections.Generic;

namespace OGANI.CartService.Infrastructure.Entities;

public partial class Address
{
    public int AddressId { get; set; }

    public int UserId { get; set; }

    public string Street { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public bool IsShippingAddress { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual UserProfile User { get; set; } = null!;
}
