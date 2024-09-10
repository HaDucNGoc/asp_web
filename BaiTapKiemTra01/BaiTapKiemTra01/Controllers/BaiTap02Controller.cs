using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class BaiTap02Controller : Controller
    {
        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel
            {
                TenSp = "Gym",
                GiaBan = " 500tỷ"
            };
            return View(sanpham);
        }
    }
}
