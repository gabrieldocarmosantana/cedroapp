using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cedro.UI.Models
{
    public class DishEditViewModel
    {
        public int RestaurantId { get; set; }
        public int DishId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}