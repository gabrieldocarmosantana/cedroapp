using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedro.Domain.Entities
{
    public class Dish
    {
        public int DishId { get; set; }
        public int RestaurantId { get;  set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
