using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TheFriendShip.Data;
using TheFriendShip.Models;

namespace TheFriendShip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _users;
        private readonly IConfiguration _configuration;

        public UsersController(IUserRepository users, IConfiguration configuration)
        {
            _users = users;
            _configuration = configuration;
        }

        [HttpGet("getusers")]
        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _users.GetUsers();
            return users;
        }

        [HttpGet("getuser/{id}")]
        public async Task<User> GetUser(string id)
        {
            var user = await _users.GetUser(id);
            return user;
        }
    }
}