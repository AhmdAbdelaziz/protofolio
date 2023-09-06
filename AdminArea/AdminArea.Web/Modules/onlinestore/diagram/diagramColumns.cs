using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminArea.onlinestore.Columns;

[ColumnsScript("onlinestore.diagram")]
[BasedOnRow(typeof(diagramRow), CheckNames = true)]
public class diagramColumns
{
    [EditLink]
    public string Name { get; set; }
    public int PrincipalId { get; set; }
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int DiagramId { get; set; }
    public int Version { get; set; }
    public byte[] Definition { get; set; }
}