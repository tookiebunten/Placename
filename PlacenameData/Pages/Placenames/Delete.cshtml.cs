#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlacenameData.Data;
using PlacenameData.Models;

namespace PlacenameData.Pages.Placenames
{
    public class DeleteModel : PageModel
    {
        private readonly PlacenameData.Data.PlacenameDataContext _context;

        public DeleteModel(PlacenameData.Data.PlacenameDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Placename Placename { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Placename = await _context.Placename.FirstOrDefaultAsync(m => m.ID == id);

            if (Placename == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Placename = await _context.Placename.FindAsync(id);

            if (Placename != null)
            {
                _context.Placename.Remove(Placename);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
