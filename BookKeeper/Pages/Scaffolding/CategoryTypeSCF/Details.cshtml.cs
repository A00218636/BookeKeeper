using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookKeeper.Data;

namespace BookKeeper.Pages.Scaffolding.CategoryTypeSCF
{
    public class DetailsModel : PageModel
    {
        private readonly BookKeeper.Data.BookKeeperDbContext _context;

        public DetailsModel(BookKeeper.Data.BookKeeperDbContext context)
        {
            _context = context;
        }

        public CategoryType CategoryType { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryType = await _context.CategoryTypes.FirstOrDefaultAsync(m => m.Type == id);

            if (CategoryType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
