using MvvmSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmSample.Services
{
    public static class LoginService
    {
        public static async Task<User> Login(string email, string password)
        {
            await Task.Delay(2000);

            return new User { FirstName = "John", LastName = "Harris" };
        }
    }
}
