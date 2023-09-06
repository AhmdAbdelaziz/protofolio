using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminArea.onlinestore.Pages;

[PageAuthorize(typeof(diagramRow))]
public class diagramPage : Controller
{
    [Route("onlinestore/diagram")]
    public ActionResult Index()
    {
        return this.GridPage("@/onlinestore/diagram/diagramPage",
            diagramRow.Fields.PageTitle());
    }
}