using Cedro.Domain.Entities;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Interfaces.Services;

namespace Cedro.Domain.Services
{
    public class DishService: ServiceBase<Dish>, IDishService
    {
        private readonly IDishRepository _dishRepository;
        public DishService(IDishRepository dishRepository)
            :base(dishRepository)
        {
            _dishRepository = dishRepository;
        }
    }
}
