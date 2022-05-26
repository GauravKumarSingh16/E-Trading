using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TradingApiSprint.NewFolder
    {
    [key]
        public class Login
        {
            public string UserName { set; get; }
            public string Password { set; get; }
        }

    internal class keyAttribute : Attribute
    {
    }

    public class Registration : Rolemaster { }

        public class Rolemaster
        {
            public object UserName { get; internal set; }
            public object LoginName { get; internal set; }
            public object Password { get; internal set; }
            public object Email { get; internal set; }
            public object ContactNo { get; internal set; }
            public int UserId { get; internal set; }
            public bool IsApporved { get; internal set; }
            public object Status { get; internal set; }
        }
    }