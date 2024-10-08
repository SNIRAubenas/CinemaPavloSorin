using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace TPBDD_Cinema.Models;

public partial class DirectorfilmactorContext : DbContext
{
    public DirectorfilmactorContext()
    {
    }

    public DirectorfilmactorContext(DbContextOptions<DirectorfilmactorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<Filmactor> Filmactors { get; set; }

    public virtual DbSet<Filmdirector> Filmdirectors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=directorfilmactor;user=CinemaTP;password=Moldovan0737345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("actor");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("director");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("film");

            entity.Property(e => e.Length).HasColumnType("time");
            entity.Property(e => e.Poster).HasColumnType("mediumblob");
            entity.Property(e => e.Summary).HasColumnType("text");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Filmactor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("filmactor");

            entity.HasIndex(e => e.IdActor, "IdActor");

            entity.HasIndex(e => e.IdFilm, "idFilm");

            entity.Property(e => e.IdActor).HasColumnName("idActor");
            entity.Property(e => e.IdFilm).HasColumnName("idFilm");

            entity.HasOne(d => d.IdActorNavigation).WithMany(p => p.Filmactors)
                .HasForeignKey(d => d.IdActor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("filmactor_ibfk_1");

            entity.HasOne(d => d.IdFilmNavigation).WithMany(p => p.Filmactors)
                .HasForeignKey(d => d.IdFilm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("filmactor_ibfk_2");
        });

        modelBuilder.Entity<Filmdirector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("filmdirector");

            entity.HasIndex(e => e.IdDirector, "idDirector");

            entity.HasIndex(e => e.IdFilm, "idFilm");

            entity.Property(e => e.IdDirector).HasColumnName("idDirector");
            entity.Property(e => e.IdFilm).HasColumnName("idFilm");

            entity.HasOne(d => d.IdDirectorNavigation).WithMany(p => p.Filmdirectors)
                .HasForeignKey(d => d.IdDirector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("filmdirector_ibfk_1");

            entity.HasOne(d => d.IdFilmNavigation).WithMany(p => p.Filmdirectors)
                .HasForeignKey(d => d.IdFilm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("filmdirector_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
