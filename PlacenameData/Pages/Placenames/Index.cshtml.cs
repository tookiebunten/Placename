
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
    public class IndexModel : PageModel
    {
        private readonly PlacenameData.Data.PlacenameDataContext _context;

        public IndexModel(PlacenameData.Data.PlacenameDataContext context)
        {
            _context = context;
        }

        public IList<Placename> Placename { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Names { get; set; }

        [BindProperty(SupportsGet = true)]
        public string PlacenameNames { get; set; }

        public async Task OnGetAsync()
        {
            //using System.Linq
            var places = from p in _context.Placename
                         select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                places = places.Where(s => s.Name.Contains(SearchString));
            }

            Placename = await _context.Placename.ToListAsync();
        }
    }
}