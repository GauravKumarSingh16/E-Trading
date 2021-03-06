using E_TradingApiSprint.NewFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TradingApiSprint.Models
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Login> Logins { get; set; }
    }
}