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
        [Key]
        public int MATD { get; set; }

        public int MADOI1 { get; set; }

        public int MADOI2 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NGAYGIO { get; set; }

        public int MASAN { get; set; }

        public int MAVONG { get; set; }

        public int? SBTDOI1 { get; set; }

        public int? SBTDOI2 { get; set; }

        public int? THOILUONG { get; set; }
    }
}
