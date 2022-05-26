using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_TradingAPI.Models
{
    public class BusinessOwner
    {
        [Key]
        //[Required]
        //public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public double Shares { get; set; }
        public int Id { get; internal set; }
    }
}