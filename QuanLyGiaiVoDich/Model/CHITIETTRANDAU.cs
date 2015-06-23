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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MABT { get; set; }

        public int? MATD { get; set; }

        public int? MACT { get; set; }

        public int THOIDIEM { get; set; }

        public int? MALOAIBT { get; set; }

        public virtual CAUTHU CAUTHU { get; set; }

        public virtual LOAIBANTHANG LOAIBANTHANG { get; set; }

        public virtual TRANDAU TRANDAU { get; set; }
    }
}
