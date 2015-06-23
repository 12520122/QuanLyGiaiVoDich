namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THEPHAT")]
    public partial class THEPHAT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATP { get; set; }

        [Required]
        [StringLength(50)]
        public string TENTP { get; set; }

        public int MATT { get; set; }

        public int MACT { get; set; }

        public int MADOI { get; set; }

        public virtual CAUTHU CAUTHU { get; set; }

        public virtual DOIBONG DOIBONG { get; set; }

        public virtual TRONGTAI TRONGTAI { get; set; }
    }
}
