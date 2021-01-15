using FoodRecipe.HttpClientFolder;
using FoodRecipe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ingredientsController : ControllerBase
    {
        private readonly HttpClientFood food;
        public ingredientsController(HttpClientFood food)
        {
            this.food = food;
        }
        [HttpGet]
        public List<ingredients> Getarea([FromQuery] int size)
        {
            return food.GetIngredient(size);
        }
    }
}
