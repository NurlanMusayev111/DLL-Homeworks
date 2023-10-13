using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_DLL_HOMEWORKS.Controllers
{
    public class UserControllers
    {
        private readonly UserService _userService;

        public UserControllers()
        {
            _userService = new UserService();
        }

        public void LoginUsers()
        {
            Console.WriteLine("Add email :");
            string email = Console.ReadLine();

            Console.WriteLine("Add your password");
            string password = Console.ReadLine();

            var result = _userService.LoginUsers(email,password);

            Console.WriteLine(result);
        }
    }
}
