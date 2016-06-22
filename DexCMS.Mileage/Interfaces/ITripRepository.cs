using System.Linq;
using DexCMS.Core.Infrastructure.Interfaces;
using DexCMS.Mileage.Models;

namespace DexCMS.Mileage.Interfaces
{
    public interface ITripRepository: IRepository<Trip>
    {
        IQueryable<Trip> GetTripsByCar(int carID);
    }
}
