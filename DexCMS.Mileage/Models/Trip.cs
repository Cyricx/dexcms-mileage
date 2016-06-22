using System;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.Mileage.Models
{
    public class Trip
    {
        public int TripID { get; set; }

        [Required]
        public int CarID { get; set; }

        [Required]
        public DateTime TripDate { get; set; }

        [Required]
        public decimal StartMiles { get; set; }

        public decimal? EndMiles { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public virtual Car Car { get; set; }
    }
}
