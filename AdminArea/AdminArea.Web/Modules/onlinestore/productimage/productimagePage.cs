using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.onlinestore.Pages;

[PageAuthorize(typeof(productimageRow))]
public class productimagePage : Controller
{
    [Route("onlinestore/productimage")]
    public ActionResult Index()
    {
        return this.GridPage("@/onlinestore/productimage/productimagePage",
            productimageRow.Fields.PageTitle());
    }
}