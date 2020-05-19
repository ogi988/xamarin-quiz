using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class UserScore
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Username { get; set; }
    }
}