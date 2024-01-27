using ComeToEgypt.DbContext.Base;
using ComeToEgypt.DbContext.Enums;
using System.ComponentModel.DataAnnotations;

namespace ComeToEgypt.Models
{
    public class Ticket : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public GovernorateCategory GovernorateCategory { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Relations

        public List<Information> Informations { get; set; }


    }
}
