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
            return View();
        }
        public ActionResult showProduct()
        {
            List<tbl_Product>
        }
    }
}