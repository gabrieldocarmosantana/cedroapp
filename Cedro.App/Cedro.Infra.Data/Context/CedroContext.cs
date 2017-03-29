using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cedro.Domain.Entities;
using Cedro.Infra.Data.EntityConfig;

namespace Cedro.Infra.Data.Context
{
    public class CedroContext : DbContext
    {
        public CedroContext()
            : base("CedroContext")
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();



            modelBuilder.Configurations.Add(new RestaurantConfiguration());
            modelBuilder.Configurations.Add(new DishConfiguration());
        }
    }
}
