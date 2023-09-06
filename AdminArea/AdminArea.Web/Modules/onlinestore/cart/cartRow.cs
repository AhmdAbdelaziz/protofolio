using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminArea.onlinestore;

[ConnectionKey("WebApplication9"), Module("onlinestore"), TableName("CART")]
[DisplayName("Cart"), InstanceName("Cart")]
[ReadPermission("cart")]
[ModifyPermission("cart")]
public sealed class cartRow : Row<cartRow.RowFields>, IIdRow, INameRow
{
    const string jProduct = nameof(jProduct);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("User Id"), QuickSearch, NameProperty]
    public string UserId
    {
        get => fields.UserId[this];
        set => fields.UserId[this] = value;
    }

    [DisplayName("Product"), ForeignKey("PRODUCTS", "Id"), LeftJoin(jProduct), TextualField(nameof(ProductName))]
    public int? ProductId
    {
        get => fields.ProductId[this];
        set => fields.ProductId[this] = value;
    }

    [DisplayName("Qty")]
    public int? Qty
    {
        get => fields.Qty[this];
        set => fields.Qty[this] = value;
    }

    [DisplayName("Product Name"), Expression($"{jProduct}.[Name]")]
    public string ProductName
    {
        get => fields.ProductName[this];
        set => fields.ProductName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField UserId;
        public Int32Field ProductId;
        public Int32Field Qty;

        public StringField ProductName;
    }
}