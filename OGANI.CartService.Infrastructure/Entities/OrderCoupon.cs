using System;
using System.Collections.Generic;

namespace OGANI.CartService.Infrastructure.Entities;

public partial class OrderCoupon
{
    public int OrderCouponId { get; set; }

    public int OrderId { get; set; }

    public int CouponId { get; set; }

    public virtual Coupon Coupon { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
