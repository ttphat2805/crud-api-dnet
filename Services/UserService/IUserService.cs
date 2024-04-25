using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_api_dnet.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<int>> Register(User user, string password);

        Task<ServiceResponse<string>> Login(string username, string password);

    }
}