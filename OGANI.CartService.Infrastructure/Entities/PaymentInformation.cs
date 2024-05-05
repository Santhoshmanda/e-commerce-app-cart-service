using System;
using System.Collections.Generic;

namespace OGANI.CartService.Infrastructure.Entities;

public partial class PaymentInformation
{
    public int PaymentId { get; set; }

    public decimal PaymentAmount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public int OrderId { get; set; }

    public virtual Order Order { get; set; } = null!;
}
