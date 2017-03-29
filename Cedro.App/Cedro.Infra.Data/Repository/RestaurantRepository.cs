using System;
using System.Data.Entity;
using System.Linq;
using Cedro.Domain.Entities;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Infra.Data.Context;

namespace Cedro.Infra.Data.Repository
{
    public class RestaurantRepository : RepositoryBase<Restaurant>, IRestaurantRepository
    {
        private readonly CedroContext _cedroContext;

        public RestaurantRepository(CedroContext cedroContext)
            : base(cedroContext)
        {
            _cedroContext = cedroContext;
        }

    }
}