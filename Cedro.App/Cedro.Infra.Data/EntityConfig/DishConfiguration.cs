using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cedro.Domain.Entities;

namespace Cedro.Infra.Data.EntityConfig
{
    public class DishConfiguration : EntityTypeConfiguration<Dish>
    {
        public DishConfiguration()
        {
            HasKey(x => x.DishId);

        }
    }
}
