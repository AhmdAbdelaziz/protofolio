using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace AdminArea.onlinestore.Columns;

[ColumnsScript("onlinestore.products")]
[BasedOnRow(typeof(productsRow), CheckNames = true)]
public class productsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Code { get; set; }
    public string CategoryName { get; set; }
    public string Photo { get; set; }
    public string SupplierName { get; set; }
    public DateTime EntryDate { get; set; }
    public string ReviewUrl { get; set; }
    public int Quantity { get; set; }
}