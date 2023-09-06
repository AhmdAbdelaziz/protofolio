using System;
using System.Collections.Generic;

namespace WebApplication9.Models;

public partial class Order
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public int? Mobile { get; set; }

    public int? UserId { get; set; }

    public bool? IsOnlinePaid { get; set; }

    public string? Useridstring { get; set; }

    public virtual ICollection<DetailOfOrder> DetailOfOrders { get; set; } = new List<DetailOfOrder>();
}
