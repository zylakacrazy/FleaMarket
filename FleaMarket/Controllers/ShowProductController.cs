using FleaMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FleaMarket.Controllers
{
    public class ShowProductController : Controller
    {
        // GET: ShowProduct
        SGDFleaMarketEntities db = new SGDFleaMarketEntities();
        public ActionResult Index()
        {
            List<tbl_Product> result = db.tbl_Product.ToList();

            return View(result);
        }
        public ActionResult showDetails(int msp)
        {
            var result1 = db.tbl_Product.SingleOrDefault(n => n.id_product==msp);
            if (result1 == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(result1);
        }
    }
}