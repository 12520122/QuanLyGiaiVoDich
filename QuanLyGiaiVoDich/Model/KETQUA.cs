namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KETQUA")]
    public partial class KETQUA
    {
        [Key]
        public int MAKQ { get; set; }

        public int? MATD { get; set; }

        public int BTDOI1 { get; set; }

        public int BTDOI2 { get; set; }

        public int THOILUONG { get; set; }

        public virtual TRANDAU TRANDAU { get; set; }
    }
}
