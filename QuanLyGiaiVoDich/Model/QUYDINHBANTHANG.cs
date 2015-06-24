namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYDINHBANTHANG")]
    public partial class QUYDINHBANTHANG
    {
        [Key]
        public int MAQD { get; set; }

        public int THOIDIEMGHIBANTOIDA { get; set; }

        public int THANG { get; set; }

        public int HOA { get; set; }

        public int THUA { get; set; }
    }
}
