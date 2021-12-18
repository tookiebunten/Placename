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
    public class DetailsModel : PageModel
    {
        private readonly PlacenameData.Data.PlacenameDataContext _context;

        public DetailsModel(PlacenameData.Data.PlacenameDataContext context)
        {
            _context = context;
        }

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
    }
}
