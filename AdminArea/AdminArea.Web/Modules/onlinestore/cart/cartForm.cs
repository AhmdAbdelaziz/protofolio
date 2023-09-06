using Serenity.ComponentModel;

namespace AdminArea.onlinestore.Forms;

[FormScript("onlinestore.cart")]
[BasedOnRow(typeof(cartRow), CheckNames = true)]
public class cartForm
{
    public string UserId { get; set; }
    public int ProductId { get; set; }
    public int Qty { get; set; }
}