using FoodRecipe.HttpClientFolder;
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
    public class areasController : ControllerBase
    {
        private readonly HttpClientFood food;
        public areasController(HttpClientFood food)
        {
            this.food = food;
        }
       


    }
}
