namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAUTHU")]
    public partial class CAUTHU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAUTHU()
        {
            DANHSACHGHIBANs = new HashSet<DANHSACHGHIBAN>();
            DOIBONG_CAUTHU = new HashSet<DOIBONG_CAUTHU>();
            THEPHATs = new HashSet<THEPHAT>();
        }

        [Key]
        public int MACT { get; set; }

        [Required]
        [StringLength(50)]
        public string TENCT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NGAYSINH { get; set; }

        [Required]
        [StringLength(50)]
        public string QUOCTICH { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public virtual BANTHANG BANTHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHGHIBAN> DANHSACHGHIBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOIBONG_CAUTHU> DOIBONG_CAUTHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THEPHAT> THEPHATs { get; set; }
    }
}
