using DexCMS.Core.Infrastructure.Repositories;
using DexCMS.Mileage.Models;
using DexCMS.Mileage.Interfaces;
using DexCMS.Core.Infrastructure.Contexts;
using DexCMS.Mileage.Contexts;
using System.Linq;

namespace DexCMS.Mileage.Repositories
{
    public class TripRepository : AbstractRepository<Trip>, ITripRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSMileageContext _ctx { get; set; }

        public TripRepository(IDexCMSMileageContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Trip> GetTripsByCar(int carID)
        {
            return _ctx.Trips.Where(t => t.CarID == carID);
        }
    }
}