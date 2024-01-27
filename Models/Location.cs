using ComeToEgypt.DbContext.Enums;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace ComeToEgypt.Models
{
    public class Location
    {
        public int Id { get; set; }
        public GovernorateCategory GovernorateCategory { get; set; }
        public string Address { get; set; }
        public string Discreption { get; set; }

        //Relations

        public List<Information> Informations { get; set; }

    }
}
