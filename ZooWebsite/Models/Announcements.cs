using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooWebsite.Models
{
    public class Announcements
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnnouncementId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Announcement Description")]
        public string AnnouncementText { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy")]
        public DateTime Date { get; set; }

    }
}
