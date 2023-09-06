using System;
using System.Collections.Generic;

namespace WebApplication9.Models;

public partial class DetailOfOrder
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public decimal Price { get; set; }

    public int? Qty { get; set; }

    public decimal? TotalPrice { get; set; }

    public int? OrderId { get; set; }

    public decimal? Priceanull { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
