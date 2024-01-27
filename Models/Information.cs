using System.ComponentModel.DataAnnotations;

namespace ComeToEgypt.Models
{
    public class Information
    {
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string KingName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public string Bdate { get; set; }
        public string Gender { get; set; }

        //Ticket
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        //Location
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
