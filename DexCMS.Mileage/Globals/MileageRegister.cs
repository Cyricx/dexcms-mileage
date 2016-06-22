using Ninject;
using DexCMS.Mileage.Contexts;
using DexCMS.Mileage.Repositories;
using DexCMS.Mileage.Interfaces;

namespace DexCMS.Mileage.Globals
{
    public static class MileageRegister<T> where T : IDexCMSMileageContext
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ICarRepository>().To<CarRepository>();
            kernel.Bind<IDriverRepository>().To<DriverRepository>();
            kernel.Bind<ITripRepository>().To<TripRepository>();
        }
    }
}
