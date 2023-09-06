using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminArea.onlinestore.Columns;

[ColumnsScript("onlinestore.productimage")]
[BasedOnRow(typeof(productimageRow), CheckNames = true)]
public class productimageColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ProductName { get; set; }
    [EditLink]
    public string Image { get; set; }
}