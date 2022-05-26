using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_TradingAPI.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]


        //public string Role { get; set; }
        //[Required]
        public double Shares { get; set; }

    }
}