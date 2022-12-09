using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Shopping.Models
{
    public partial class ONLine_ShoppingContext : DbContext
    {
        public ONLine_ShoppingContext()
        {
        }

        public ONLine_ShoppingContext(DbContextOptions<ONLine_ShoppingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sample> Samples { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=tcp:levelupsolutions.database.windows.net,1433;Initial Catalog=ONLine_Shopping;Persist Security Info=False;User ID=test-user;Password=Jay.shree9591;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("us_type");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CId).HasColumnName("C_Id");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PId).HasColumnName("P_Id");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__Product__A3420A57351C9630");

                entity.ToTable("Product");

                entity.Property(e => e.PId).HasColumnName("P_Id");

                entity.Property(e => e.PColor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("P_Color");

                entity.Property(e => e.PName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("P_Name");

                entity.Property(e => e.PPrize).HasColumnName("P_Prize");

                entity.Property(e => e.PSize)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("P_Size");

                entity.Property(e => e.PType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("P_Type");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sample");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PK__Users__A9FDEC1256ED3A89");

                entity.Property(e => e.CId).HasColumnName("C_ID");

                entity.Property(e => e.CEmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_EmailId");

                entity.Property(e => e.CFname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_FName");

                entity.Property(e => e.CLname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_LName");

                entity.Property(e => e.CMobileNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_MobileNumber");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("us_type");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("User_Type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.UsType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("us_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
