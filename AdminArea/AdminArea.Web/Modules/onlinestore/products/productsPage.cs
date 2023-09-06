using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.onlinestore.Pages;

[PageAuthorize(typeof(productsRow))]
public class productsPage : Controller
{
    [Route("onlinestore/products")]
    public ActionResult Index()
    {
        return this.GridPage("@/onlinestore/products/productsPage",
            productsRow.Fields.PageTitle());
    }
}