using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_api_dnet.Dtos.User
{
    public class UserLoginDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}