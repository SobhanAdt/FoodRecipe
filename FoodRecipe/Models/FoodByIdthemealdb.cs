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

        public string strAera { get; set; }

        public string strMealThumb { get; set; }

        public string strstrInstructions { get; set; }
    }

    public class FoodByIdthemealdbList
    {
        public  List<FoodByIdthemealdb> meals { get; set; }
    }
}
