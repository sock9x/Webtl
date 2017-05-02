namespace webamnhac.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhacsi")]
    public partial class nhacsi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhacsi()
        {
            baihat = new HashSet<baihat>();
        }

        [StringLength(50)]
        public string tennhacsi { get; set; }

        [Key]
        [StringLength(20)]
        public string manhacsi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<baihat> baihat { get; set; }
    }
}
