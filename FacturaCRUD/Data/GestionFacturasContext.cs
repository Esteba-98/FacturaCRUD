using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FacturaCRUD.Models;

public partial class GestionFacturasContext : DbContext
{
    public GestionFacturasContext()
    {
    }

    public GestionFacturasContext(DbContextOptions<GestionFacturasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Factura> Facturas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facturas__3214EC07B418F7B3");

            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
