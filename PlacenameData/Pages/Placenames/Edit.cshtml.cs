#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlacenameData.Data;
using PlacenameData.Models;

namespace PlacenameData.Pages.Placenames
{
    public class EditModel : PageModel
    {
        private readonly PlacenameData.Data.PlacenameDataContext _context;

        public EditModel(PlacenameData.Data.PlacenameDataContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Placename).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlacenameExists(Placename.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PlacenameExists(int id)
        {
            return _context.Placename.Any(e => e.ID == id);
        }
    }
}
