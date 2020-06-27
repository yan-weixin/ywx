using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("Cart")]
    public class CartDO
        {
            [Key] public long Id { get; set; }

            [StringLength(100)] public string ProductNumber { get; set; }

            [StringLength(100)] public string ProductName { get; set; }

            [StringLength(100)] public string ProductType { get; set; }
            [StringLength(100)] public int Shuliang { get; set; }
            [StringLength(100)] public double Price { get; set; }
            //地址
            [StringLength(300)] public string ImgUrl { get; set; }
            [StringLength(100)] public string UserName { get; set; }
            
            [StringLength(100)] public string Total { get; set; }
        [StringLength(300)] public string Time{ get; set; }
    }
    
}
