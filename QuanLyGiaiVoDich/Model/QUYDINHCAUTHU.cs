namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYDINHCAUTHU")]
    public partial class QUYDINHCAUTHU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAQD { get; set; }

        public int TUOITOITHIEU { get; set; }

        public int TUOITOIDA { get; set; }

        public int SOCTTOITHIEU { get; set; }

        public int SOCTTOIDA { get; set; }

        public int SOCTNUOCNGOAITOIDA { get; set; }
    }
}
