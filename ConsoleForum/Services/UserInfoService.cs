using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Services
{
    internal class UserInfoService
    { 
        private readonly UserInfoService _userInfoService;
        private readonly UserService _userService;

        public UserInfoService(UserInfoService userInfoService, UserService userService)
        {
            _userInfoService = userInfoService;
            _userService = userService;
        }
    }
}
