namespace webamnhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("casi")]
    public partial class casi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public casi()
        {
            baihat = new HashSet<baihat>();
        }

        [StringLength(50)]
        public string tencasi { get; set; }

        public string thongtin { get; set; }

        [Key]
        [StringLength(20)]
        public string macasi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<baihat> baihat { get; set; }
    }
}
