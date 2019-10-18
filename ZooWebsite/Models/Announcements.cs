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
        [Column(TypeName = "nvarchar(30)")]
        [Display(Name = "Title")]
        public string AnnouncementTitle { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        [Display(Name = "Announcement")]
        [DataType(DataType.MultilineText)]
        public string AnnouncementText { get; set; }

        public DateTime Date { get; set; }

    }
}
