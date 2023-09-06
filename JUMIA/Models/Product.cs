using System;
using System.Collections.Generic;

namespace WebApplication9.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }

    public int? Code { get; set; }

    public int? CategoryId { get; set; }

    public string? Photo { get; set; }

    public string? SupplierName { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? ReviewUrl { get; set; }

    public int? Quantity { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<DetailOfOrder> DetailOfOrders { get; set; } = new List<DetailOfOrder>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
}
