namespace webamnhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("baihat")]
    public partial class baihat
    {
        [StringLength(50)]
        public string ten { get; set; }

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        public DateTime? thoigianphathanh { get; set; }

        public DateTime? thoigianban { get; set; }

        [StringLength(1000)]
        public string thongtin { get; set; }

        [StringLength(200)]
        public string anh { get; set; }

        [StringLength(1000)]
        public string linkbaihat { get; set; }

        public double? gia { get; set; }

        [StringLength(50)]
        public string tentheloai { get; set; }

        [StringLength(20)]
        public string macasi { get; set; }

        [StringLength(20)]
        public string manhacsi { get; set; }

        public virtual casi casi { get; set; }

        public virtual nhacsi nhacsi { get; set; }

        public virtual theloai theloai { get; set; }
    }
}
