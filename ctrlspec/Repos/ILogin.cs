using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;

namespace ctrlspec.Repos
{
    public interface ILogin
    {
       

        Task<Login> SignUp(Login loginTable);
        Task<Login> Login(string emailId, string Password);

    }
}