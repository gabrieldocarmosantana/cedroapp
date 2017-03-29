using Cedro.Application.Interfaces;
using Cedro.Domain.Entities;
using Cedro.Domain.Interfaces.Services;

namespace Cedro.Application.Services
{
    public class DishAppService : AppServiceBase<Dish>, IDishAppService
    {
        private readonly IDishService _dishService;
        public DishAppService(IDishService dishService)
            :base(dishService)
        {
            _dishService = dishService;
        }
    }
}
