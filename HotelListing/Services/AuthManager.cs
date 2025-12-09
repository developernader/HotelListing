using HotelListing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Services
{
    public class AuthManager : IAuthManager
    {
        public Task<string> CreateToken()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateUser(LoginUserDTO loginUserDTO)
        {
            throw new NotImplementedException();
        }
    }
}
