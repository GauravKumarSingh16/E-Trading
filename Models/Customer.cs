using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_TradingApiSprint.Models
{
    public class Customer
    {
        [Key]
        public int UserId { get; set; }
            [Required]

            public string Password { get; set; }
            [Required]
            public double Balance { get; set; }
            [Required]
            public double Shares { get; set; }

        }
    }