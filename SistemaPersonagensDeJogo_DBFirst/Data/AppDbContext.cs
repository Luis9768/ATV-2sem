using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaPersonagensDeJogo_DBFirst.Models;

namespace SistemaPersonagensDeJogo_DBFirst.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TabelaPersonagensF> TabelaPersonagensFs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TabelaPersonagensF>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TabelaFuncionario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
