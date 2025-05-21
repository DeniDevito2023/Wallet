using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Wallet.Model;

public partial class ProbnicV2Context : DbContext
{
    public ProbnicV2Context()
    {
    }

    public ProbnicV2Context(DbContextOptions<ProbnicV2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ExpenceProduct> ExpenceProducts { get; set; }

    public virtual DbSet<FamilyJob> FamilyJobs { get; set; }

    public virtual DbSet<FamilyMember> FamilyMembers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ProbnicV2;Username=postgres;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExpenceProduct>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("ExpenceProduct_pkey");

            entity.ToTable("ExpenceProduct", "FamilyV2");

            entity.Property(e => e.IdProduct).HasColumnName("idProduct");
            entity.Property(e => e.SalesFns).HasColumnName("salesFNS");
            entity.Property(e => e.SalesProduct).HasColumnName("salesProduct");

            entity.HasOne(d => d.SalesFnsNavigation).WithMany(p => p.ExpenceProducts)
                .HasForeignKey(d => d.SalesFns)
                .HasConstraintName("ExpenceProduct_salesFNS_fkey");

            entity.HasOne(d => d.SalesProductNavigation).WithMany(p => p.ExpenceProducts)
                .HasForeignKey(d => d.SalesProduct)
                .HasConstraintName("ExpenceProduct_salesProduct_fkey");
        });

        modelBuilder.Entity<FamilyJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FamilyJob_pkey");

            entity.ToTable("FamilyJob", "FamilyV2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Doljnost).HasColumnType("character varying");
            entity.Property(e => e.IdFns).HasColumnName("idFNS");
            entity.Property(e => e.Organisation).HasColumnType("character varying");

            entity.HasOne(d => d.IdFnsNavigation).WithMany(p => p.FamilyJobs)
                .HasForeignKey(d => d.IdFns)
                .HasConstraintName("FamilyJob_idFNS_fkey");
        });

        modelBuilder.Entity<FamilyMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FamilyMembers_pkey");

            entity.ToTable("FamilyMembers", "FamilyV2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fns)
                .HasMaxLength(50)
                .HasColumnName("FNS");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Product_pkey");

            entity.ToTable("Product", "FamilyV2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasColumnType("character varying")
                .HasColumnName("category");
            entity.Property(e => e.NameProduct).HasColumnType("character varying");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
