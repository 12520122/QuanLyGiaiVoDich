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
        [Key]
        public int MACT { get; set; }

        [Required]
        [StringLength(50)]
        public string TENCT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NGAYSINH { get; set; }

        public int? MALOAICT { get; set; }

        [Required]
        [StringLength(50)]
        public string QUOCTICH { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }
    }
}
