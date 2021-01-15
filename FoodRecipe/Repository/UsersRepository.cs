using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodRecipe.Models;

namespace FoodRecipe.Repository
{
    public interface IUserRepository
    {
        void Insert(Register register);
        Register GetByEmail(string email);

    }
    public class UsersRepository : IUserRepository
    {
        private static List<Register> Registers = new List<Register>();

        public void Insert(Register register)
        {
            if (!Registers.Any(x => x.email == register.email))
            {
                Registers.Add(register);

            }
            else
            {
                return; 
            }
        }

        public Register GetByEmail(string email)
        {
            return Registers.FirstOrDefault(x => x.email == email);
        }
    }
}
