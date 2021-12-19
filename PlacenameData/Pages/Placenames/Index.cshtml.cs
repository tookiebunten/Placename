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

        public IList<Placename> Name { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Parish { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PlaceType { get; set; }

        public async Task OnGetAsync()
        {
            var placename = from p in _context.Placename
                            select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                placename = placename.Where(s => s.Name.Contains(SearchString));
            }


            Name = await placename.ToListAsync();
        }
    }
}
