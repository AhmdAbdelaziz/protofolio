using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        OnlineStoreContext db=new OnlineStoreContext();


        public IActionResult Index()
        {
            Indexvm result = new Indexvm();
            result.products=db.Products.ToList();
            result.categories=db.Categories.ToList();
            result.reviews=db.Reviews.ToList();
            result.latestproducts=db.Products.OrderByDescending(x=>x.EntryDate).Take(4).ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult categories()
        {
            var result = db.Categories.ToList();

            return View(result);
        }
        

        public IActionResult products(int id)
        {
           

            var result = db.Products.Where(x=>x.CategoryId==id).ToList();
            
            return View(result);
        }

        public IActionResult currentproduct(int id)
        {


            var result = db.Products.Include(x=>x.ProductImages).Include(x=>x.Category).FirstOrDefault(x => x.Id == id);

            return View(result);
        }



        [HttpGet]
        public IActionResult searchproduct(string xname)
        {


            var result = new List<Product>();
            if (string.IsNullOrEmpty(xname))
            {result = db.Products.ToList();
                
            }
            else {result=db.Products.Where(x=>x.Name.Contains(xname)).ToList(); }
            

            return View(result);
        }

        [HttpPost]
        public IActionResult review(Review model)
        {


            db.Reviews.Add(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



        [Authorize]
        public IActionResult AddToCart(int id)
        {
            var price = db.Products.Find(id).Price;
            var item=db.Carts.FirstOrDefault(x=>x.ProductId== id && x.UserId==User.Identity.Name);

            if (item != null)
            {
                item.Qty += 1;
            }
            else
            {
                db.Carts.Add(new Cart { ProductId = id,UserId=User.Identity.Name,Qty=1,Price=price});
            }
            db.SaveChanges ();
            

            return RedirectToAction("Cart");
        }


        [Authorize]

        public IActionResult Cart()
        {
            var result= db.Carts.Include(x=>x.Product).Where(x=>x.UserId==User.Identity.Name).ToList();
            return View(result);
        }
        public IActionResult buyer()
        {

            return View();
        }


        [HttpPost]
        [Authorize]
        public IActionResult AddOrder( Order model)
        {
            Order o=new Order { Name=model.Name
                               ,Address=model.Address
                               ,Email=model.Email
                               ,Mobile=model.Mobile
                               ,Useridstring=User.Identity.Name};

            var cartitems = db.Carts.Where(x => x.UserId == User.Identity.Name);

            foreach (var item in cartitems) 
            {
                var totalprice = item.Qty * item.Price;
                o.DetailOfOrders.Add(new DetailOfOrder {ProductId=item.ProductId,Priceanull=item.Price,Qty=item.Qty,TotalPrice=totalprice});
            }
            db.Carts.RemoveRange(cartitems);
            db.Orders.Add(o);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult myorders()
        {
            var order = db.Orders.Include(x => x.DetailOfOrders).ThenInclude(x => x.Product).Where(x => x.Useridstring == User.Identity.Name).ToList();

            return View(order);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}