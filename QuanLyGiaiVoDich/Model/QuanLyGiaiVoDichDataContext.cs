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

        public virtual DbSet<BANGXEPHANG> BANGXEPHANGs { get; set; }
        public virtual DbSet<BANTHANG> BANTHANGs { get; set; }
        public virtual DbSet<BOPHAN> BOPHANs { get; set; }
        public virtual DbSet<CAUTHU> CAUTHUs { get; set; }
        public virtual DbSet<CHITIETTRANDAU> CHITIETTRANDAUs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DANHSACHGHIBAN> DANHSACHGHIBANs { get; set; }
        public virtual DbSet<DOIBONG> DOIBONGs { get; set; }
        public virtual DbSet<DOIBONG_CAUTHU> DOIBONG_CAUTHU { get; set; }
        public virtual DbSet<DOIBONG_MUAGIAI> DOIBONG_MUAGIAI { get; set; }
        public virtual DbSet<GIAMSATVIEN> GIAMSATVIENs { get; set; }
        public virtual DbSet<KETQUA> KETQUAs { get; set; }
        public virtual DbSet<MUAGIAI> MUAGIAIs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHATAITRO> NHATAITROes { get; set; }
        public virtual DbSet<QUYDINHBANTHANG> QUYDINHBANTHANGs { get; set; }
        public virtual DbSet<QUYDINHCAUTHU> QUYDINHCAUTHUs { get; set; }
        public virtual DbSet<SAN> SANs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THEPHAT> THEPHATs { get; set; }
        public virtual DbSet<TRANDAU> TRANDAUs { get; set; }
        public virtual DbSet<TRONGTAI> TRONGTAIs { get; set; }
        public virtual DbSet<VONGDAU> VONGDAUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BOPHAN>()
                .HasMany(e => e.CHUCVUs)
                .WithRequired(e => e.BOPHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAUTHU>()
                .HasOptional(e => e.BANTHANG)
                .WithRequired(e => e.CAUTHU);

            modelBuilder.Entity<CAUTHU>()
                .HasMany(e => e.DANHSACHGHIBANs)
                .WithRequired(e => e.CAUTHU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAUTHU>()
                .HasMany(e => e.DOIBONG_CAUTHU)
                .WithRequired(e => e.CAUTHU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAUTHU>()
                .HasMany(e => e.THEPHATs)
                .WithRequired(e => e.CAUTHU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIENs)
                .WithMany(e => e.CHUCVUs)
                .Map(m => m.ToTable("NHAVIEN_CHUCVU").MapLeftKey("MACV").MapRightKey("MANV"));

            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.BANGXEPHANGs)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.DANHSACHGHIBANs)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.DOIBONG_CAUTHU)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.DOIBONG_MUAGIAI)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOIBONG>()
                .HasMany(e => e.THEPHATs)
                .WithRequired(e => e.DOIBONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUAGIAI>()
                .HasMany(e => e.DOIBONG_CAUTHU)
                .WithRequired(e => e.MUAGIAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUAGIAI>()
                .HasMany(e => e.DOIBONG_MUAGIAI)
                .WithRequired(e => e.MUAGIAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUAGIAI>()
                .HasMany(e => e.NHATAITROes)
                .WithRequired(e => e.MUAGIAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAN>()
                .HasMany(e => e.DOIBONG_MUAGIAI)
                .WithOptional(e => e.SAN)
                .HasForeignKey(e => e.MASANNHA);

            modelBuilder.Entity<SAN>()
                .HasMany(e => e.TRANDAUs)
                .WithRequired(e => e.SAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRANDAU>()
                .HasMany(e => e.BANGXEPHANGs)
                .WithRequired(e => e.TRANDAU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRONGTAI>()
                .HasMany(e => e.THEPHATs)
                .WithRequired(e => e.TRONGTAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VONGDAU>()
                .HasMany(e => e.TRANDAUs)
                .WithRequired(e => e.VONGDAU)
                .WillCascadeOnDelete(false);
        }
    }
}
