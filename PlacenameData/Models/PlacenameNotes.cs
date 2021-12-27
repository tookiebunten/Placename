namespace PlacenameData.Models
{
    public class PlacenameNotes
    {
        //id	name_id	variation_id	notes

        public int Id { get; set; }
        public string NameId { get; set; }// from PlacenameData.Models.Placename.NameId
        public string VariationId { get; set; }// from PlacenameData.Models.PlacenameVariations.Id
        public string Notes { get; set; }
    }
}
