using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TheFriendShip.Models
{
    public class LoginDTO
    {
        public ClaimsIdentity UserName { get; set; }
    }
}
