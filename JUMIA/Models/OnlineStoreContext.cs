using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication9.Models;

public partial class OnlineStoreContext : DbContext
{
    public OnlineStoreContext()
    {
    }

    public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<DetailOfOrder> DetailOfOrders { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=OnlineStore;Trusted_Connection=True; TrustServerCertificate=True;encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.ToTable("CART");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Product).WithMany(p => p.Carts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_CART_PRODUCTS");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("CATEGORY");
        });

        modelBuilder.Entity<DetailOfOrder>(entity =>
        {
            entity.ToTable("DetailOfOrder");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Priceanull)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PRICEANULL");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Order).WithMany(p => p.DetailOfOrders)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_DetailOfOrder_Order");

            entity.HasOne(d => d.Product).WithMany(p => p.DetailOfOrders)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_DetailOfOrder_PRODUCTS");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Useridstring)
                .HasMaxLength(50)
                .HasColumnName("USERIDSTRING");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("PRODUCTS");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReviewUrl).HasColumnName("ReviewURL");
            entity.Property(e => e.SupplierName).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_PRODUCTS_CATEGORY");
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.ProductImages)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductImages_PRODUCTS");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.ToTable("REVIEW");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
