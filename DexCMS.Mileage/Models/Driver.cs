using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.Mileage.Models
{
    public class Driver
    {
        [StringLength(256)]
        public string DriverID { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
