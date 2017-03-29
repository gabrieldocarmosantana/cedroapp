using Cedro.Domain.Entities;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Interfaces.Services;

namespace Cedro.Domain.Services
{
    public class RestaurantService : ServiceBase<Restaurant>, IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        public RestaurantService(IRestaurantRepository restaurantRepository)
            : base(restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
    }
}
