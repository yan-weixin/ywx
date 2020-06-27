﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("Products")]

    public class ProductDO
    {
        [Key] public long Id { get; set; }

        [StringLength(100)] public string ProductNumber { get; set; }

        [StringLength(100)] public string ProductName { get; set; }

        [StringLength(100)] public string ProductType { get; set; }
        [StringLength(100)] public int Shuliang { get; set; }
        [StringLength(100)] public double Price { get; set; }
        [StringLength(300)] public string ImgUrl { get; set; }
        [StringLength(500)] public string Jianjie { get; set; }

    }
}
