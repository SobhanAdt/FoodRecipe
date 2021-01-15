using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipe.Models
{
    public class UserInfo
    {
        public string email { get; set; }

        public List<favorites> favorites { get; set; }
    }
}
