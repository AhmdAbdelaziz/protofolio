using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.onlinestore.Pages;

[PageAuthorize(typeof(categoryRow))]
public class categoryPage : Controller
{
    [Route("onlinestore/category")]
    public ActionResult Index()
    {
        return this.GridPage("@/onlinestore/category/categoryPage",
            categoryRow.Fields.PageTitle());
    }
}