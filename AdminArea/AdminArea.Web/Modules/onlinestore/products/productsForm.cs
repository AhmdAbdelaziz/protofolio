using Serenity.ComponentModel;
using System;

namespace AdminArea.onlinestore.Forms;

[FormScript("onlinestore.products")]
[BasedOnRow(typeof(productsRow), CheckNames = true)]
public class productsForm
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Code { get; set; }
    public int CategoryId { get; set; }
    public string Photo { get; set; }
    public string SupplierName { get; set; }
    public DateTime EntryDate { get; set; }
    public string ReviewUrl { get; set; }
    public int Quantity { get; set; }
}