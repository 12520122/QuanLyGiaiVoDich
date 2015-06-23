namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAICAUTHU")]
    public partial class LOAICAUTHU
    {
        [Key]
        public int MALOAICT { get; set; }

        [Required]
        [StringLength(20)]
        public string LOAICT { get; set; }
    }
}
