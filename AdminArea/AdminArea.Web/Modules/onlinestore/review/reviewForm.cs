using Serenity.ComponentModel;

namespace AdminArea.onlinestore.Forms;

[FormScript("onlinestore.review")]
[BasedOnRow(typeof(reviewRow), CheckNames = true)]
public class reviewForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Subject { get; set; }
    public string Email { get; set; }
}