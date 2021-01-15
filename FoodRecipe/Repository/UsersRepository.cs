using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodRecipe.Models;

namespace FoodRecipe.Repository
{
    public class UsersRepository
    {
        private static List<Register> Registers = new List<Register>();

        public void Insert(Register register)
        {
            Registers.Add(register);
        }

        public Register GetByEmail(string email)
        {
            return Registers.FirstOrDefault(x => x.email == email);
        }
    }
}
