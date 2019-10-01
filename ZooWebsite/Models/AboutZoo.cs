using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooWebsite.Models
{
    public class AboutZoo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "About Zoo Id")]
        public int AboutZooID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "About Zoo Description")]
        public string Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

    }
}
