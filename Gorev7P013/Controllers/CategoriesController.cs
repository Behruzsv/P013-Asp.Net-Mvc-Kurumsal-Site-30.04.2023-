using Gorev7P013.Data;
using Gorev7P013.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gorev7P013.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            if (id is null)
            {
                return BadRequest();
            }
            var category = _context.Categories.Include(p => p.Products).FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //public IActionResult Index()
        //{
        //    var data = new List<Slider>();
        //    return View();
        //}
    }
}
