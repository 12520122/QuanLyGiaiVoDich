namespace QuanLyGiaiVoDich.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyGiaiVoDichDataContext : DbContext
    {
        public QuanLyGiaiVoDichDataContext()
            : base("name=QuanLyGiaiVoDichDataContext")
        {
        }

        public virtual DbSet<CAUTHU> CAUTHUs { get; set; }
        public virtual DbSet<CHITIETTRANDAU> CHITIETTRANDAUs { get; set; }
        public virtual DbSet<DOIBONG> DOIBONGs { get; set; }
        public virtual DbSet<LOAIBANTHANG> LOAIBANTHANGs { get; set; }
        public virtual DbSet<LOAICAUTHU> LOAICAUTHUs { get; set; }
        public virtual DbSet<SAN> SANs { get; set; }
        public virtual DbSet<TRANDAU> TRANDAUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
