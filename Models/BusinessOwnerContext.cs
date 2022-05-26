using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TradingAPI.Models
{
    public class BusinessOwnerContext : DbContext
    {
        public BusinessOwnerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<BusinessOwner> BusinessOwners { get; set; }
    }
}
