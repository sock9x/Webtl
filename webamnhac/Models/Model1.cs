namespace webamnhac.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=webbannhac")
        {
        }

        public virtual DbSet<baihat> baihat { get; set; }
        public virtual DbSet<casi> casi { get; set; }
        public virtual DbSet<khachhang> khachhang { get; set; }
        public virtual DbSet<nhacsi> nhacsi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<theloai> theloai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<baihat>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<baihat>()
                .Property(e => e.macasi)
                .IsUnicode(false);

            modelBuilder.Entity<baihat>()
                .Property(e => e.manhacsi)
                .IsUnicode(false);

            modelBuilder.Entity<casi>()
                .Property(e => e.macasi)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang>()
                .Property(e => e.maKH)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<nhacsi>()
                .Property(e => e.manhacsi)
                .IsUnicode(false);

            modelBuilder.Entity<theloai>()
                .Property(e => e.matheloai)
                .IsUnicode(false);
        }
    }
}
