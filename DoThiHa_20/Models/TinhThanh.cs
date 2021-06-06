using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoThiHa_20.Models
{
    [Table("TinhThanhs")]
    public class TinhThanh
    {
        [Key]
        public int MaTinhThanh { get; set; }
        [MaxLength(50)]
        public string TenTinhThanh { get; set; }
    }
}