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
        //List<Product> prod = new List<Product>();
        public ActionResult Index(int? page) {

            int PageSize = 9;
            int PageNumber = (page ?? 1);
            // db.Products.OrderBy(i => i.Id).Skip(PageNumber * PageSize).Take(PageSize
            //db.Products.OrderBy(i => i.Id).ToPagedList(PageNumber, PageSize)

           // ViewBag.Products = db.Products;
            return View(db.Products.OrderBy(m=>m.Id).ToPagedList(PageNumber, PageSize));
        }
        [HttpPost]
        public ActionResult BookSearch(string Search)
        {
            var allbooks = db.Products.Where(a => a.Name.Contains(Search)).ToList();
          
            return View(allbooks);
        }



        public ActionResult SortbyPrice()
        {



          var res= db.Products.OrderBy(m=>m.Price).ToList();
         

            return View(res) ;
        }
        public ActionResult SortbydesPrice()
        {



            var res = db.Products.OrderBy(m => m.Price).ToList();
            res.Reverse();
            return View(res);
            
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