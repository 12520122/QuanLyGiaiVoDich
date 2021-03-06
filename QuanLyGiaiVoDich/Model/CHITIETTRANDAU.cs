namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETTRANDAU")]
    public partial class CHITIETTRANDAU
    {
        [Key]
        public int MACHITIET { get; set; }

        public int? MABT { get; set; }

        public int? MATD { get; set; }

        public virtual BANTHANG BANTHANG { get; set; }

        public virtual TRANDAU TRANDAU { get; set; }
    }
}
