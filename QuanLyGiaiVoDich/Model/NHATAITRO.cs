namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHATAITRO")]
    public partial class NHATAITRO
    {
        [Key]
        public int MANTT { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNTT { get; set; }

        [Required]
        public string HINHTHUCTT { get; set; }

        public int MAMUA { get; set; }

        public virtual MUAGIAI MUAGIAI { get; set; }
    }
}
