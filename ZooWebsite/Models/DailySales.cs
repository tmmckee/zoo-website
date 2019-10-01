using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooWebsite.Models
{
    public class DailySales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Ticket Id")]
        public int TicketId { get; set; }

        [Required]
        [Display(Name = "Number of Tickets")]
        public int NumberOfTickets { get; set; }

        [DataType(DataType.Date)]
        public DateTime SaleDate { get; set; }

    }
}
