using System.ComponentModel.DataAnnotations;

namespace PlacenameData.Models
{
    public class Placename
    {
        //idx	name_id	name	nation	region	parish	parish_short
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty; //placename 

        [StringLength(100)]
        public string Nation { get; set; } = string.Empty; //nation of placename eg Scotland

        [StringLength(100)]
        public string Region { get; set; } = string.Empty; //region of placename eg South Lanarkshire

        [StringLength(100)]
        public string Parish { get; set; } = string.Empty; //parish of placename eg Lesmahagow

        [StringLength(3)]
        public string ParishShort { get; set; } = string.Empty; //short version of placename eg LEW

        [DataType(DataType.Date)]
        public DateTime DateEntered { get; set; } //might not need

    }
}
