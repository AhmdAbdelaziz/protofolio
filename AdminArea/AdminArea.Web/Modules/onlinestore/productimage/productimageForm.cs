using Serenity.ComponentModel;

namespace AdminArea.onlinestore.Forms;

[FormScript("onlinestore.productimage")]
[BasedOnRow(typeof(productimageRow), CheckNames = true)]
public class productimageForm
{
    public int ProductId { get; set; }
    public string Image { get; set; }
}