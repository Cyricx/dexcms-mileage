using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.Mileage.Models
{
    public class Car
    {
        public int CarID { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(100)]
        public string Make { get; set; }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        [Required]
        [StringLength(256)]
        public string UserID { get; set; }

        public virtual ICollection<Driver> Drivers { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
