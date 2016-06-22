using System.Data.Entity;
using DexCMS.Core.Infrastructure.Contexts;
using DexCMS.Mileage.Models;

namespace DexCMS.Mileage.Contexts
{
    public interface IDexCMSMileageContext : IDexCMSContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<Driver> Drivers { get; set; }
        DbSet<Trip> Trips { get; set; }
    }
}
