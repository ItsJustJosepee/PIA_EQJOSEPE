using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PIA_EQJOSEPE.Models;

public partial class BdJuegosContext : DbContext
{
    public BdJuegosContext()
    {
    }

    public BdJuegosContext(DbContextOptions<BdJuegosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Juego> Juegos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Juego>(entity =>
        {
            entity.HasKey(e => e.IdJuego).HasName("PK__Juegos__DB51539340A1EABC");

            entity.Property(e => e.IdJuego).HasColumnName("Id_juego");
            entity.Property(e => e.Categoria)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Creador)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Modalidad)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NombreJuego)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Nombre_juego");
            entity.Property(e => e.Tipo)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__EF59F76298B96550");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsu)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Nombre_usu");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
