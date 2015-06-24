namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAMSATVIEN")]
    public partial class GIAMSATVIEN
    {
        [Key]
        public int MAGSV { get; set; }

        [Required]
        [StringLength(50)]
        public string TENGSV { get; set; }
    }
}
