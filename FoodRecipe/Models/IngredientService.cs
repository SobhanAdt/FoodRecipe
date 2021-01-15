using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipe.Models
{
    public class IngredientService
    {
        public string idIngredient { get; set; }
        public string strIngredient { get; set; }
    }
    public class ingredientslst
    {
        public List<IngredientService> meals { get; set; }
    }
}
