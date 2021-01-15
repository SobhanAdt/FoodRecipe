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
        private readonly HttpClientFood client;

        public foodsController(HttpClientFood client)
        {
            this.client = client;
        }

        [HttpGet("{id}")]
        public foodsById GetById(int id)
        {
            return client.GetById(id);
        }
    }
}
