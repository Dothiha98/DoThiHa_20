namespace DoThiHa_20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HangHoas
    {
        [Key]
        public string MaHangHoa { get; set; }

        public string TenHangHoa { get; set; }

        [StringLength(15)]
        public string SoLuong { get; set; }

        public string GhiChu { get; set; }
    }
}
