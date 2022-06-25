using Microsoft.AspNetCore.Mvc;

namespace NewsSite.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext db;

        public CategoryController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Categories.ToListAsync());
        }
    }
}
