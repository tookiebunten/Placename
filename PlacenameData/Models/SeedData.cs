using Microsoft.EntityFrameworkCore;
using PlacenameData.Data;

namespace PlacenameData.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlacenameDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PlacenameDataContext>>()))
            {
                if (context == null || context.Placename == null)
                {
                    throw new ArgumentNullException("Null PlacenamesDataContext");
                }

                // Look for any movies.
                if (context.Placename.Any())
                {
                    return;   // DB has been seeded
                }

                context.Placename.AddRange(
                    new Placename
                    {
                        Name = "Blackwood",
                        Nation = "Scotland",
                        Region = "South Lanarkshire",
                        Parish = "Lesmahagow",
                        ParishShort = "LEW",
                        DateEntered = DateTime.Parse("18-12-2021")
                    },

                    new Placename
                    {
                        Name = "Auchtyfardle",
                        Nation = "Scotland",
                        Region = "South Lanarkshire",
                        Parish = "Lesmahagow",
                        ParishShort = "LEW",
                        DateEntered = DateTime.Parse("18-12-2021")
                    },

                    new Placename
                    {
                        Name = "Lesmahagow",
                        Nation = "Scotland",
                        Region = "South Lanarkshire",
                        Parish = "Lesmahagow",
                        ParishShort = "LEW",
                        DateEntered = DateTime.Parse("18-12-2021")
                    },

                    new Placename
                    {
                        Name = "Kerse",
                        Nation = "Scotland",
                        Region = "South Lanarkshire",
                        Parish = "Lesmahagow",
                        ParishShort = "LEW",
                        DateEntered = DateTime.Parse("18-12-2021")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
