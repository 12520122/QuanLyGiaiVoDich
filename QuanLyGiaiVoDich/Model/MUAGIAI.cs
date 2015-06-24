namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUAGIAI")]
    public partial class MUAGIAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUAGIAI()
        {
            DOIBONG_CAUTHU = new HashSet<DOIBONG_CAUTHU>();
            DOIBONG_MUAGIAI = new HashSet<DOIBONG_MUAGIAI>();
            NHATAITROes = new HashSet<NHATAITRO>();
            VONGDAUs = new HashSet<VONGDAU>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAMUA { get; set; }

        [Required]
        [StringLength(50)]
        public string TENMUA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TGBATDAU { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TGKETTHUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOIBONG_CAUTHU> DOIBONG_CAUTHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOIBONG_MUAGIAI> DOIBONG_MUAGIAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHATAITRO> NHATAITROes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VONGDAU> VONGDAUs { get; set; }
    }
}
