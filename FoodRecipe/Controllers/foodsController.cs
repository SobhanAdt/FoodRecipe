using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodRecipe.HttpClientFolder;
using FoodRecipe.Models;

namespace FoodRecipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class foodsController : ControllerBase
    {
        private readonly HttpClientFood clientFood;
        public foodsController(HttpClientFood clientFood)
        {
            this.clientFood = clientFood;
        }
        [HttpGet]
        public List<Food> GetFood([FromQuery] GetFoodByFilter filter)
        {
            switch (filter.cat)
            {
                case "ing":
                    return clientFood.GetFoodByIng(filter.selected);
                case "meal":
                    return clientFood.GetFoodBycat(filter.cat);
                case "area":
                    return clientFood.GetFoodByarea(filter.area);

                default:
                    {
                        throw new ArgumentException("Invalid Category");
                    }
            }
            return null;
            
        }
    }
}
