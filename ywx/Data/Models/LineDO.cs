using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{

    [Table("Line")]
     public class LineDO
    {
        [Key] public long Id { get; set; }


        [StringLength(100)] public double Total { get; set; }
        //地址
        [StringLength(300)] public string Adress { get; set; }
        [StringLength(100)] public string UserName { get; set; }
        [StringLength(100)] public string Zhuangtai { get; set; }

        [StringLength(300)] public string Time { get; set; }
    }
}
