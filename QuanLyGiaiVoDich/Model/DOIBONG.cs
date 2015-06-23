namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOIBONG")]
    public partial class DOIBONG
    {
        [Key]
        public int MADOI { get; set; }

        [Required]
        [StringLength(50)]
        public string TENDOI { get; set; }
    }
}
