using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.Services
{
    public class UserService
    {
        private User[] GetAllUsers()
        {
            User user1 = new()
            {
                Id = 1,
                FullName = "Nurlan Musayev",
                Age = 21,
                Email = "nurlan@code.az",
                Password = "nurlan123"
            };

            User user2 = new()
            {
                Id = 2,
                FullName = "Rufet Nesibov",
                Age = 24,
                Email = "rufat@code.az",
                Password = "rufat123"
            };

            User user3 = new()
            {
                Id = 3,
                FullName = "Samil Ferruxov",
                Age = 27,
                Email = "samil@code.az",
                Password = "samil123"
            };

            User[] users = { user1, user2, user3 };
            return users;
        }

        public string LoginUsers(string email,string password)
        {
            User[] users = GetAllUsers();

            foreach(var user in users)
            {
                if (user.Email == email && user.Password == password) 
                {
                    return "Login success";
                }
            }

            return "email or password wrong";
        }
    }

}
