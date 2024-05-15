using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ASP.NET_CRUD_PostgreSQL.Models;

namespace ASP.NET_CRUD_PostgreSQL.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
