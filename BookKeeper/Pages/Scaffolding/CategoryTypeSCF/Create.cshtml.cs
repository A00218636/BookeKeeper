using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookKeeper.Data;

namespace BookKeeper.Pages.Scaffolding.CategoryTypeSCF
{
    public class CreateModel : PageModel
    {
        private readonly BookKeeper.Data.BookKeeperDbContext _context;

        public CreateModel(BookKeeper.Data.BookKeeperDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CategoryType CategoryType { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CategoryTypes.Add(CategoryType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
