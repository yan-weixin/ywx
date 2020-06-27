using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyShop.Models
{
    public class CartLine
    {
        public CartVO Product { get; set; }
        public int Quantity { get; set; }
    }
}
