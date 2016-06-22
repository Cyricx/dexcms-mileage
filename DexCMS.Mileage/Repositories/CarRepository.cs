using DexCMS.Core.Infrastructure.Repositories;
using DexCMS.Mileage.Models;
using DexCMS.Mileage.Interfaces;
using DexCMS.Core.Infrastructure.Contexts;
using DexCMS.Mileage.Contexts;

namespace DexCMS.Mileage.Repositories
{
    public class CarRepository : AbstractRepository<Car>, ICarRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSMileageContext _ctx { get; set; }

        public CarRepository(IDexCMSMileageContext ctx)
        {
            _ctx = ctx;
        }
    }
}