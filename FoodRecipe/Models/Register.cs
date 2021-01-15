using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipe.Models
{
    public class Register
    {
        public string email { get; set; }

        public List<string> favorites { get; set; }
    }
}
