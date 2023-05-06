using Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Api
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserRegister> User { get; set; }
    }
}
