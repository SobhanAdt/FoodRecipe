using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodRecipe.Models;
using FoodRecipe.Repository;

namespace FoodRecipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UsersRepository repository;

        public UsersController(UsersRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public string Create([FromBody] Register register)
        {
            repository.Insert(register);
            return register.email;
        }
    }
}
