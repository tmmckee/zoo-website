using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooWebsite.Models
{
    public class AnimalType
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimalTypeId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "Animal Type")]
        public string Type { get; set; }

    }
}
