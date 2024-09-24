using Microsoft.AspNetCore.Mvc;

namespace projectA.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
