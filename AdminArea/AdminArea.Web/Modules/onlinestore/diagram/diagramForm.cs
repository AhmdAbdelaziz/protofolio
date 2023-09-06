using Serenity.ComponentModel;

namespace AdminArea.onlinestore.Forms;

[FormScript("onlinestore.diagram")]
[BasedOnRow(typeof(diagramRow), CheckNames = true)]
public class diagramForm
{
    public string Name { get; set; }
    public int PrincipalId { get; set; }
    public int Version { get; set; }
    public byte[] Definition { get; set; }
}