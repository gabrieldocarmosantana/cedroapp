using Cedro.Domain.Entities;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Infra.Data.Context;

namespace Cedro.Infra.Data.Repository
{
    public class DishRepository : RepositoryBase<Dish>, IDishRepository
    {
        private readonly CedroContext _cedroContext;

        public DishRepository(CedroContext cedroContext)
            : base(cedroContext)
        {
            _cedroContext = cedroContext;
        }
    }
}