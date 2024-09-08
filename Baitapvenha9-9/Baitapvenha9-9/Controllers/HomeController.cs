using Baitapvenha9_9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Baitapvenha9_9.Controllers
{
  
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                ViewBag.HoTen = "Hà Đức Ngọc";
                ViewBag.MSSV = "1822040920";
                ViewData["Nam"] = "Năm 2004";
                return View();
            }


        }
    
}
