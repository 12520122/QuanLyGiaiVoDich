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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAKQ { get; set; }

        public int? MATD { get; set; }

        [Column("KETQUA")]
        [Required]
        [StringLength(20)]
        public string KETQUA1 { get; set; }

        public int DIEM { get; set; }

        public virtual TRANDAU TRANDAU { get; set; }
    }
}
