using Cedro.Application.Interfaces;
using Cedro.Domain.Entities;
using Cedro.Domain.Interfaces.Services;

namespace Cedro.Application.Services
{
    public class RestaurantAppService : AppServiceBase<Restaurant>, IRestaurantAppService
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantAppService(IRestaurantService restaurantService)
            : base(restaurantService)
        {
            _restaurantService = restaurantService;
        }


    }
}
