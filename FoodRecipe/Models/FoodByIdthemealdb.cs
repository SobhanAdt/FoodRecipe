using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipe.Models
{
    public class FoodByIdthemealdb
    {
        public string idMeal { get; set; }

        public string strMeal { get; set; }

        public string strCategory { get; set; }

        public string strArea { get; set; }

        public string strMealThumb { get; set; }

        public string strInstructions { get; set; }
    }

    public class FoodByIdthemealdbList
    {
        public  List<FoodByIdthemealdb> meals { get; set; }
    }
}
