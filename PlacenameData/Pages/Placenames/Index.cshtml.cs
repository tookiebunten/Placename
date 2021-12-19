
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
    public class IndexModel : PageModel
    {
        private readonly PlacenameData.Data.PlacenameDataContext _context;

        public IndexModel(PlacenameData.Data.PlacenameDataContext context)
        {
            _context = context;
        }

        public IList<Placename> Placename { get; set; }

        public async Task OnGetAsync()
        {
            Placename = await _context.Placename.ToListAsync();
        }
    }
}