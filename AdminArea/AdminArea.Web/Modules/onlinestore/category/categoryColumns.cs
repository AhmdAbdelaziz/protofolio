using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminArea.onlinestore.Columns;

[ColumnsScript("onlinestore.category")]
[BasedOnRow(typeof(categoryRow), CheckNames = true)]
public class categoryColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Photo { get; set; }
    public string Description { get; set; }
}