using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TradingAPI.Models
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
    }
}