#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlacenameData.Models;

namespace PlacenameData.Data
{
    public class PlacenameDataContext : DbContext
    {
        public PlacenameDataContext (DbContextOptions<PlacenameDataContext> options)
            : base(options)
        {
        }

        public DbSet<PlacenameData.Models.Placename> Placename { get; set; }
    }
}
