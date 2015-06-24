namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANTHANG")]
    public partial class BANTHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANTHANG()
        {
            CHITIETTRANDAUs = new HashSet<CHITIETTRANDAU>();
        }

        [Key]
        public int MABT { get; set; }

        public int? MACT { get; set; }

        public int? MADOI { get; set; }

        public int THOIGIAN { get; set; }

        public virtual CAUTHU CAUTHU { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTRANDAU> CHITIETTRANDAUs { get; set; }
    }
}
