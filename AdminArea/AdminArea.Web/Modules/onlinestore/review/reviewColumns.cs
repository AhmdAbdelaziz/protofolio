using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminArea.onlinestore.Columns;

[ColumnsScript("onlinestore.review")]
[BasedOnRow(typeof(reviewRow), CheckNames = true)]
public class reviewColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public string Subject { get; set; }
    public string Email { get; set; }
}