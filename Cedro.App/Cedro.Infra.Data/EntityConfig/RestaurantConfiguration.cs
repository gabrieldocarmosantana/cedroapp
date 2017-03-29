using System.Data.Entity.ModelConfiguration;
using Cedro.Domain.Entities;

namespace Cedro.Infra.Data.EntityConfig
{
    public class RestaurantConfiguration :EntityTypeConfiguration<Restaurant>
    {
        public RestaurantConfiguration()
        {
            HasKey(x => x.RestaurantId);

            HasMany(x => x.Dishes)
                .WithRequired(x => x.Restaurant)
                .HasForeignKey(x => x.RestaurantId);

        }
    }
}
