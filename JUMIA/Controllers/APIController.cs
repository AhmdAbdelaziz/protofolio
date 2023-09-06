using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        OnlineStoreContext db=new OnlineStoreContext();

        [HttpGet("getproduct")]
        public IActionResult getproduct()
        {
            return Ok(db.Products.Include(x => x.Category).Select(x => new {x.Id,x.Name,x.Price,x.Quantity,
                CategName=x.Category==null?"":x.Category.Name}).ToList());
        }

        [HttpPost("createproduct")]
        public IActionResult createproduct(Product model)
        {
            try {db.Products.Add(model);
            db.SaveChanges();
            return Ok("done"); }
            catch (Exception ex) { return BadRequest(ex.Message); }
            
        }

        [HttpDelete("deleteproduct/{id}")]
        public IActionResult deleteproduct(int id)
        {
            var result = db.Products.Find(id);
            if(result != null)
            {
                db.Products.Remove(result);
                db.SaveChanges();
            }

            return Ok("done");
                
           

        }
    }
}
