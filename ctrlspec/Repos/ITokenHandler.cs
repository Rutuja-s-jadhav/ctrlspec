using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;

namespace ctrlspec.Repos
{
    public interface ITokenHandler
    {
         Task<string> CreateTokenAsync(Login loginTable);
    }
}