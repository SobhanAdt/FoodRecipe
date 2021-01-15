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
    public class categoriesController : ControllerBase
    {
        private readonly HttpClientFood food;
        public categoriesController(HttpClientFood food)
        {
            this.food = food;
        }
        [HttpGet]
        public List<categories> Getarea([FromQuery] int size)
        {
            return food.GetCatgory(size);
        }
    }
}
