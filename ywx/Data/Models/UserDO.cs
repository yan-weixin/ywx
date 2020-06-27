using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("Users")]
    public class UserDO
    {
        [Key] public long Id { get; set; }

        [StringLength(100)] public string UserNumber { get; set; }

        [StringLength(100)] public string UserPassword { get; set; }
        [StringLength(100)] public string Phonenumber { get; set; }
        [StringLength(300)] public string Email { get; set; }
        //性别
        [StringLength(100)] public string Radio { get; set; }
        //家庭住址
        [StringLength(300)] public string City { get; set; }
        //生日
        [StringLength(300)] public string Date { get; set; }




    }
}
