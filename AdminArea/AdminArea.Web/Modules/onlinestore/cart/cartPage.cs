using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.onlinestore.Pages;

[PageAuthorize(typeof(cartRow))]
public class cartPage : Controller
{
    [Route("onlinestore/cart")]
    public ActionResult Index()
    {
        return this.GridPage("@/onlinestore/cart/cartPage",
            cartRow.Fields.PageTitle());
    }
}