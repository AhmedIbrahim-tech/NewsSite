using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext db;

        public HomeController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
