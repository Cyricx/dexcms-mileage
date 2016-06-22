using DexCMS.Core.Infrastructure.Repositories;
using DexCMS.Mileage.Models;
using DexCMS.Mileage.Interfaces;
using DexCMS.Core.Infrastructure.Contexts;
using DexCMS.Mileage.Contexts;

namespace DexCMS.Mileage.Repositories
{
    public class DriverRepository : AbstractRepository<Driver>, IDriverRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSMileageContext _ctx { get; set; }

        public DriverRepository(IDexCMSMileageContext ctx)
        {
            _ctx = ctx;
        }
    }
}