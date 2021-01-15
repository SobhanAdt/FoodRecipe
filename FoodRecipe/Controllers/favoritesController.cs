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
    public class favoritesController : ControllerBase
    {
        private readonly HttpClientFood client;

        public favoritesController(HttpClientFood client)
        {
            this.client = client;
        }

        [HttpGet]
        public List<Food> GetFavorites([FromQuery] string email)
        {
            return client.GetFavorites(email);
        }
    }
}
