using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyShop.Models
{
    public class CartVO
    {
        public long Id { get; set; }
        public string ProductNumber { get; set; }

        public string ProductName { get; set; }

        public string ProductType { get; set; }

        public string Price { get; set; }
         public int Shuliang { get; set; }
        
       
        public string UserName { get; set; }
       public string Total { get; set; }
         public string Time { get; set; }


    }
}
