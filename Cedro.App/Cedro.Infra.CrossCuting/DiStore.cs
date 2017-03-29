using Cedro.Application.Interfaces;
using Cedro.Application.Services;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Interfaces.Services;
using Cedro.Domain.Services;
using Cedro.Infra.Data.Context;
using Cedro.Infra.Data.Repository;
using SimpleInjector;

namespace Cedro.Infra.CrossCuting
{
    public class DiStore
    {
        public static void Inject(Container container)
        {
            container.Register<CedroContext>(Lifestyle.Scoped);
            container.Register<IRestaurantAppService, RestaurantAppService>(Lifestyle.Scoped);
            container.Register<IDishAppService, DishAppService>(Lifestyle.Scoped);
            container.Register<IRestaurantService, RestaurantService>(Lifestyle.Scoped);
            container.Register<IDishService, DishService>(Lifestyle.Scoped);
            container.Register<IRestaurantRepository, RestaurantRepository>(Lifestyle.Scoped);
            container.Register<IDishRepository, DishRepository>(Lifestyle.Scoped);
        }

    }
}