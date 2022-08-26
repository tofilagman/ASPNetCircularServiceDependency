using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AService A;
        private readonly BService B;

        public HomeController(AService a, BService b)
        {
            A = a;
            B = b;
        }

        //Home/GetA
        public async Task<IActionResult> GetA()
        {
            return Json(await A.TestBCall());
        }

        //Home/GetB
        public async Task<IActionResult> GetB()
        {
            return Json(await B.TestACall());
        }
    }
}