using Gorev7P013.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gorev7P013.ViewComponents
{
	public class Categories : ViewComponent
	{
		public readonly DatabaseContext _context;
		public Categories (DatabaseContext context)
		{
			_context = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View(await _context.Categories.ToListAsync());
		}
	}
}
