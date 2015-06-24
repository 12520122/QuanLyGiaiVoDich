namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANDAU")]
    public partial class TRANDAU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANDAU()
        {
            BANGXEPHANGs = new HashSet<BANGXEPHANG>();
            CHITIETTRANDAUs = new HashSet<CHITIETTRANDAU>();
            KETQUAs = new HashSet<KETQUA>();
        }

        [Key]
        public int MATD { get; set; }

        public int MADOI1 { get; set; }

        public int MADOI2 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NGAYGIO { get; set; }

        public int MASAN { get; set; }

        public int MAVONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGXEPHANG> BANGXEPHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTRANDAU> CHITIETTRANDAUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUA> KETQUAs { get; set; }

        public virtual SAN SAN { get; set; }

        public virtual VONGDAU VONGDAU { get; set; }
    }
}
