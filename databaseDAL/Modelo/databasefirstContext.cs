using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace databaseDAL.Modelo
{
    public partial class databasefirstContext : DbContext
    {
        public databasefirstContext()
        {
        }

        public databasefirstContext(DbContextOptions<databasefirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;
        public virtual DbSet<Asignatura> Asignaturas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=databasefirst;User Id=postgres;Password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.ToTable("alumnos");

                entity.HasComment("Entidad que regula los alumnos del centro");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Apellido)
                    .HasColumnType("character varying")
                    .HasColumnName("apellido");

                entity.Property(e => e.Nombre)
                    .HasColumnType("character varying")
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.HasComment("Entidad que regula las asignaturas del centro");

                entity.Property(e => e.AsignaturaId)
                    .HasColumnName("asignatura_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.AsignaturaNombre)
                    .HasColumnType("character varying")
                    .HasColumnName("asignatura_nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
