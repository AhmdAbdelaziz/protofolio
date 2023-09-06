using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.onlinestore.Pages;

[PageAuthorize(typeof(reviewRow))]
public class reviewPage : Controller
{
    [Route("onlinestore/review")]
    public ActionResult Index()
    {
        return this.GridPage("@/onlinestore/review/reviewPage",
            reviewRow.Fields.PageTitle());
    }
}