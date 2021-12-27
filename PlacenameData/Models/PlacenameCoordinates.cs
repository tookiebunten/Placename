using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlacenameData.Models
{
    public class PlacenameCoordinates
    {

        //id NameId os_sheet	os_grid_10	osgb_east	osgb_north	easting(x)	northing(y)	longitude	latitude

        public int Id { get; set; }
        public string NameId { get; set; } // from PlacenameData.Models.Placename.NameId
        [Display(Name ="OS Sheet")]
        [StringLength(2)]
        public string OsSheet { get; set; } // OS map grid ref eg NS
        [Display(Name ="OS Grid 10")]
        [StringLength (12)]
        public string OsGrid10 { get; set; } // Ordance survey 10 figure grid ref eg NS1234512345
        [Display(Name ="OSGB East")]
        public string OsGbEast { get; set; }

        [Display(Name ="OSGB North")]
        public string OsGbNorth { get; set; }
        public string Easting { get; set; }
        public string Northing { get; set; }
        [Required]
        public string Longitude { get; set; } // Required so it can be plotted on a map 
        [Required]
        public string Latitude { get; set; }  // Required so it can be plotted on a map

    }
}
