namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOIBONG")]
    public partial class DOIBONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOIBONG()
        {
            BANGXEPHANGs = new HashSet<BANGXEPHANG>();
            DANHSACHGHIBANs = new HashSet<DANHSACHGHIBAN>();
            DOIBONG_CAUTHU = new HashSet<DOIBONG_CAUTHU>();
            DOIBONG_MUAGIAI = new HashSet<DOIBONG_MUAGIAI>();
            THEPHATs = new HashSet<THEPHAT>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MADOI { get; set; }

        [Required]
        [StringLength(50)]
        public string TENDOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGXEPHANG> BANGXEPHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHGHIBAN> DANHSACHGHIBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOIBONG_CAUTHU> DOIBONG_CAUTHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOIBONG_MUAGIAI> DOIBONG_MUAGIAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THEPHAT> THEPHATs { get; set; }
    }
}
