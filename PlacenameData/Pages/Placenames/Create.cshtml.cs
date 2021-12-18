#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlacenameData.Data;
using PlacenameData.Models;

namespace PlacenameData.Pages.Placenames
{
    public class CreateModel : PageModel
    {
        private readonly PlacenameData.Data.PlacenameDataContext _context;

        public CreateModel(PlacenameData.Data.PlacenameDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Placename Placename { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Placename.Add(Placename);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
