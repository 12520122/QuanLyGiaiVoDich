namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGXEPHANG")]
    public partial class BANGXEPHANG
    {
        [Key]
        public int MAXH { get; set; }

        public int MATD { get; set; }

        public int MADOI { get; set; }

        [Required]
        [StringLength(50)]
        public string TENDOI { get; set; }

        public int THANG { get; set; }

        public int HOA { get; set; }

        public int THUA { get; set; }

        public int HIEUSO { get; set; }

        public int HANG { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }

        public virtual TRANDAU TRANDAU { get; set; }
    }
}
