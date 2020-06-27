using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyShop.Models
{
    public class UserVO
    {
        public long Id { get; set; }

        public string UserNumber { get; set; }

        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string Radio { get; set; }
        public string City { get; set; }
        public string Date { get; set; }
    }
}