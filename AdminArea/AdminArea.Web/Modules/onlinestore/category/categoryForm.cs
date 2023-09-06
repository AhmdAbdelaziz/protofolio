using Serenity.ComponentModel;

namespace AdminArea.onlinestore.Forms;

[FormScript("onlinestore.category")]
[BasedOnRow(typeof(categoryRow), CheckNames = true)]
public class categoryForm
{
    public string Name { get; set; }
    public string Photo { get; set; }
    public string Description { get; set; }
}