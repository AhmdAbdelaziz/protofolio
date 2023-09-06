using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdminArea.onlinestore;

[ConnectionKey("WebApplication9"), Module("onlinestore"), TableName("PRODUCTS")]
[DisplayName("Products"), InstanceName("Products")]
[ReadPermission("products")]
[ModifyPermission("products")]
public sealed class productsRow : Row<productsRow.RowFields>, IIdRow, INameRow
{
    const string jCategory = nameof(jCategory);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Price"), Size(18)]
    public decimal? Price
    {
        get => fields.Price[this];
        set => fields.Price[this] = value;
    }

    [DisplayName("Description")]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Code")]
    public int? Code
    {
        get => fields.Code[this];
        set => fields.Code[this] = value;
    }

    [DisplayName("Category"), ForeignKey("CATEGORY", "Id"), LeftJoin(jCategory), TextualField(nameof(CategoryName))]
    [LookupEditor(typeof(categoryRow))]
    public int? CategoryId
    {
        get => fields.CategoryId[this];
        set => fields.CategoryId[this] = value;
    }

    [DisplayName("Photo"),ImageUploadEditor]
    public string Photo
    {
        get => fields.Photo[this];
        set => fields.Photo[this] = value;
    }

    [DisplayName("Supplier Name"), Size(50)]
    public string SupplierName
    {
        get => fields.SupplierName[this];
        set => fields.SupplierName[this] = value;
    }

    [DisplayName("Entry Date")]
    public DateTime? EntryDate
    {
        get => fields.EntryDate[this];
        set => fields.EntryDate[this] = value;
    }

    [DisplayName("Review Url"), Column("ReviewURL")]
    public string ReviewUrl
    {
        get => fields.ReviewUrl[this];
        set => fields.ReviewUrl[this] = value;
    }

    [DisplayName("Quantity")]
    public int? Quantity
    {
        get => fields.Quantity[this];
        set => fields.Quantity[this] = value;
    }

    [DisplayName("Category Name"), Expression($"{jCategory}.[Name]")]
    public string CategoryName
    {
        get => fields.CategoryName[this];
        set => fields.CategoryName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public DecimalField Price;
        public StringField Description;
        public Int32Field Code;
        public Int32Field CategoryId;
        public StringField Photo;
        public StringField SupplierName;
        public DateTimeField EntryDate;
        public StringField ReviewUrl;
        public Int32Field Quantity;

        public StringField CategoryName;
    }
}