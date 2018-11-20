using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFriendShip.Models;

namespace TheFriendShip.Data
{
    public class DbContext : IdentityDbContext<User>
    {
        public DbContext (DbContextOptions<DbContext> options) : base(options)
        {

        }
    }
}
