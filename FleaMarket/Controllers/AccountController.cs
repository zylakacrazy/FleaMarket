using FleaMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FleaMarket.Controllers
{
    public class AccountController : Controller
    {
        SGDFleaMarketEntities db = new SGDFleaMarketEntities();
        // GET: Account
        public ActionResult Login(string thongBao)
        {
            ViewBag.thongbao = thongBao;
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string tk, string mk)
        {
            var result = (from a in db.tbl_Account
                                       where a.username == tk && a.password == mk
                                       select a).ToList();
            if(result.Count > 0)
            {
                return RedirectToAction("Login", new { thongBao = "Không Sai tên đăng nhập hoặc mật khẩu" });
            }
            else
            {
                return RedirectToAction("Login", new { thongBao = "Sai tên đăng nhập hoặc mật khẩu" });
            }
        }
    }
}