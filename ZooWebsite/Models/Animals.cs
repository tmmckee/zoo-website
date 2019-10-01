using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooWebsite.Models
{
    public class Animals
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AnimalId { get; set; }

        [Display(Name = "Animal Name")]
        [Required]
        [StringLength(20)]
        [DataType(DataType.Text)]
        public string AnimalName { get; set; }

        [Display(Name = "Animal Description")]
        [Required]
        [MinLength(100, ErrorMessage = "Description should be atleast 100 characters.")]
        [DataType(DataType.MultilineText)]
        public string AnimalDescription { get; set; }

    }
}
