namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIBANTHANG")]
    public partial class LOAIBANTHANG
    {
        [Key]
        public int MALOAIBT { get; set; }

        [Required]
        [StringLength(20)]
        public string LOAIBT { get; set; }
    }
}
