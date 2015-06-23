namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VONGDAU")]
    public partial class VONGDAU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VONGDAU()
        {
            TRANDAUs = new HashSet<TRANDAU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAVONG { get; set; }

        [Required]
        [StringLength(50)]
        public string TENVONG { get; set; }

        public int? MAMUA { get; set; }

        public virtual MUAGIAI MUAGIAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU> TRANDAUs { get; set; }
    }
}
