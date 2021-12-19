using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlacenameData.Models
{
    public class Placename
    {
        //idx	name_id	name	nation	region	parish	parish_short
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }  //placename 

        [StringLength(100)]
        public string Nation { get; set; }  //nation of placename eg Scotland

        [StringLength(100)]
        public string Region { get; set; }  //region of placename eg South Lanarkshire

        [StringLength(100)]
        public string Parish { get; set; }  //parish of placename eg Lesmahagow

        [Display(Name ="Parish Short")]
        [StringLength(3)]
        public string ParishShort { get; set; }  //short version of placename eg LEW

        [Display(Name = "Date Entered")]
        [DataType(DataType.Date)]
        public DateTime DateEntered { get; set; } //might not need

    }
}
