﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObject.Object
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
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=123;database=CakeManagement");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cake>(entity =>
            {
                entity.ToTable("Cake");

                entity.Property(e => e.Cakeid).HasColumnName("cakeid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Cakename)
                    .IsRequired()
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
                    .HasDefaultValueSql("(N'Quận 9')");

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
                    .HasConstraintName("FK__Orders__staffid__74AE54BC");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderDetail");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Cakeid).HasColumnName("cakeid");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Totalprice)
                    .HasColumnType("money")
                    .HasColumnName("totalprice");

                entity.HasOne(d => d.Cake)
                    .WithMany()
                    .HasForeignKey(d => d.Cakeid)
                    .HasConstraintName("FK__OrderDeta__cakei__7C4F7684");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.Orderid)
                    .HasConstraintName("FK__OrderDeta__order__7B5B524B");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Users__AB6E61644D5858AF")
                    .IsUnique();

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
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
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
