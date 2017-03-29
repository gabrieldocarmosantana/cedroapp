using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cedro.UI.Models
{
    public class DishRegisterViewModel
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}