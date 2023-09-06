using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class ProductsController : Controller
    {
        OnlineStoreContext db = new OnlineStoreContext();

        public IActionResult Index()
        {
           var result= db.Categories.Select(x => new {x.Id,x.Name}).ToList();
            ViewBag.catlist = new SelectList(result, "Id", "Name");
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductVM model)
        {
            if(ModelState.IsValid)
            {
                Category categ = new Category();
                categ.Name=model.CategoryName;
                db.Products.Add(new Product
                {
                    Name=model.ProducName,Price=model.ProducPrice,Quantity=model.ProducQuantity,Category=categ
                });
                db.SaveChanges();

                return View("Index");
            }
            else {return View("Index",model); }

            
        }
        public IActionResult charts()
        {

                return View();
 
        }
    }
}
