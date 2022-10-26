using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CF_API_In_centralizer.Models
{
    public partial class DBCOMPREFACILContext : DbContext
    {
        public DBCOMPREFACILContext()
        {
        }

        public DBCOMPREFACILContext(DbContextOptions<DBCOMPREFACILContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cfproduct> Cfproducts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Password=Insp1r0n@;Persist Security Info=True;User ID=sa;Initial Catalog=DBCOMPREFACIL;Data Source=RS\\SQLEXPRESS");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cfproduct>(entity =>
            {
                entity.ToTable("CFPRODUCTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DataOcorrencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_OCORRENCIA");

                entity.Property(e => e.Preco).HasColumnName("PRECO");

                entity.Property(e => e.Produto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PRODUTO");

                entity.Property(e => e.Supermercado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUPERMERCADO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
