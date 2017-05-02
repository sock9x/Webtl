namespace webamnhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("khachhang")]
    public partial class khachhang
    {
        [StringLength(50)]
        public string tenKH { get; set; }

        [Key]
        [StringLength(20)]
        public string maKH { get; set; }

        [StringLength(11)]
        public string sodienthoai { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string taikhoan { get; set; }

        [StringLength(20)]
        public string matkhau { get; set; }
    }
}
