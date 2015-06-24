namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DOIBONG_MUAGIAI
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAMUA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MADOI { get; set; }

        public int? MASANNHA { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }

        public virtual MUAGIAI MUAGIAI { get; set; }

        public virtual SAN SAN { get; set; }
    }
}
