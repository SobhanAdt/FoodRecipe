using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipe.Models
{
    public class GetFoodByFilter
    {
        public string cat { get; set; }
        public string selected { get; set; }
        public string area { get; set; }
    }
}
