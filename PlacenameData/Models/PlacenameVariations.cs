using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlacenameData.Models
{
    public class PlacenameVariations
    {

        //id NameId VariationSpelling VariationSource VariationSourceDate VariationComments

        public int VariationId { get; set; }
        public string NameId { get; set; } //from PlacenameData.Models.Placename.NameId
        public string VariationSpelling { get; set; } //spelling variation of place-name
        public string VariationSource { get; set; } //source of variation, web address, journal, book etc
        public DateTime VariationSourceDate { get; set; } //just needs to be set to 4 digit year
        public string VariationComments { get; set; } //user comments about the variation

        public ICollection<Placename> Placenames { get; set; }

    }
}
