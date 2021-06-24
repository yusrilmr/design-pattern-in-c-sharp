using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPattern
{
    class Authentication
    {
        public Authentication(IUserService userService)
        {
            userService.ShowName();
            userService.ShowAge();
            userService.ShowAccessLevel();
        }
    }
}
