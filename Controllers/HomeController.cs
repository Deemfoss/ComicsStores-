using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicsStores.Models;
using System.Data.Entity;
using PagedList.Mvc;
using PagedList;


namespace ComicsStores.Controllers
{
   
    public class HomeController : Controller
    {
        StoreContext db = new StoreContext();
        public ActionResult Index(int? page,string sortOrder,string search) {

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            
            var c = from p in db.Products select p;

            if (! String.IsNullOrEmpty( search))
            {
                c = c.Where( s=> s.Name.Contains(search));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    c  = db.Products.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    c = db.Products.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    c = db.Products.OrderByDescending(s => s.Date);
                    break;
                case "price_desc":
                    c = db.Products.OrderByDescending(s => s.Price);
                    break;
                case "Price":
                    c = db.Products.OrderBy(s => s.Price);
                    break;

                default:
                    c = db.Products.OrderBy(s => s.Name);
                    break;


                   
            }

            ViewBag.result = c.ToList();

            int PageSize = 9;
            int PageNumber = (page ?? 1);
           return View(c.ToPagedList(PageNumber, PageSize));

        }
        
      
        
  
        public ActionResult Description(int id )
        {
            var Description = db.Products.Find(id);
                //bb.Products.Where(i => i.Id == id);


            return View(Description);
        }

        public ActionResult Categoryes()
        {
            
            return View(db.Categoryies);
        }


        public ActionResult CtegoryDet(int id)
        {
            ViewBag.CategoryDet= db.Products.Where(m => m.Category == id);
            return View();
        }


        public ActionResult AboutStore()
        {
            
               return View();
        }
        public ActionResult Delivery()
        {

            return View();
        }
      

    }
}