namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHSACHGHIBAN")]
    public partial class DANHSACHGHIBAN
    {
        [Key]
        public int MAGB { get; set; }

        public int MACT { get; set; }

        [Required]
        [StringLength(50)]
        public string TENCT { get; set; }

        public int MADOI { get; set; }

        [Required]
        [StringLength(50)]
        public string TENDOI { get; set; }

        [Required]
        [StringLength(20)]
        public string LOAICT { get; set; }

        public int? SOBANTHANG { get; set; }

        public virtual CAUTHU CAUTHU { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }
    }
}
