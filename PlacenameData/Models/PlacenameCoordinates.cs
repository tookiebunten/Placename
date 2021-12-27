namespace PlacenameData.Models
{
    public class PlacenameCoordinates
    {

        //id NameId os_sheet	os_grid_10	osgb_east	osgb_north	easting(x)	northing(y)	longitude	latitude

        public int Id { get; set; }
        public string NameId { get; set; } // from PlacenameData.Models.Placename.NameId
        public string OsSheet { get; set; } 
        public string OsGrid10 { get; set; } // Ordance survey 10 figure grid ref
        public string OsGbEast { get; set; }
        public string OsGbNorth { get; set; }
        public string Easting { get; set; }
        public string Northing { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

    }
}
