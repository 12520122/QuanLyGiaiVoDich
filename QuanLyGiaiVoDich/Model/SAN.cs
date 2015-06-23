namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAN")]
    public partial class SAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAN()
        {
            DOIBONG_MUAGIAI = new HashSet<DOIBONG_MUAGIAI>();
            TRANDAUs = new HashSet<TRANDAU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASAN { get; set; }

        [Required]
        [StringLength(50)]
        public string TENSAN { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        public int? SUCCHUA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOIBONG_MUAGIAI> DOIBONG_MUAGIAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU> TRANDAUs { get; set; }
    }
}
