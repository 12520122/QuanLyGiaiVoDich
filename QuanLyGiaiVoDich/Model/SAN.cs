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
        [Key]
        public int MASAN { get; set; }

        [Required]
        [StringLength(50)]
        public string TENSAN { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        public int? SUCCHUA { get; set; }
    }
}
