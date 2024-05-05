using System;
using System.Collections.Generic;

namespace OGANI.CartService.Infrastructure.Entities;

public partial class Coupon
{
    public int CouponId { get; set; }

    public string CoupounCode { get; set; } = null!;

    public decimal DiscountAmount { get; set; }

    public DateTime ExpiryDate { get; set; }

    public int? ProductId { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderCoupon> OrderCoupons { get; set; } = new List<OrderCoupon>();

    public virtual Product? Product { get; set; }
}
