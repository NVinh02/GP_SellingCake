using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BusinessObject.Object;

#nullable disable

namespace BusinessObject.DBContext
{
    public partial class CakeManagementContext : DbContext
    {
        public CakeManagementContext()
        {
        }

        public CakeManagementContext(DbContextOptions<CakeManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cake> Cakes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=admin;database=CakeManagement");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cake>(entity =>
            {
                entity.ToTable("Cake");

                entity.HasIndex(e => e.Cakename, "UQ__Cake__3C7A13CA4C5FB5A6")
                    .IsUnique();

                entity.Property(e => e.Cakeid).HasColumnName("cakeid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Cakename)
                    .HasMaxLength(50)
                    .HasColumnName("cakename");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("category");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Createddate)
                    .HasColumnType("date")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Customeraddress)
                    .HasMaxLength(50)
                    .HasColumnName("customeraddress")
                    .HasDefaultValueSql("(N'Quan 9')");

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("customername");

                entity.Property(e => e.Customerphonenumber)
                    .HasMaxLength(10)
                    .HasColumnName("customerphonenumber")
                    .HasDefaultValueSql("(N'None')");

                entity.Property(e => e.Shippingdate)
                    .HasColumnType("date")
                    .HasColumnName("shippingdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Shippingfee)
                    .HasColumnType("money")
                    .HasColumnName("shippingfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.Totalprice)
                    .HasColumnType("money")
                    .HasColumnName("totalprice");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK__Orders__staffid__08B54D69");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.Orderid, e.Cakeid })
                    .HasName("PK__OrderDet__2505F1336D9ECCB9");

                entity.ToTable("OrderDetail");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Cakeid).HasColumnName("cakeid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Totalprice)
                    .HasColumnType("money")
                    .HasColumnName("totalprice");

                entity.HasOne(d => d.Cake)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Cakeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__cakei__114A936A");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__order__10566F31");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username, "UQ__Users__F3DBC572DF0101AB")
                    .IsUnique();

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fullname");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("password");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(10)
                    .HasColumnName("phonenumber");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
