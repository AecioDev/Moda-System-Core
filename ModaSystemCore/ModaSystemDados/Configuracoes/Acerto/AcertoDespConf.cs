using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class AcertoDespConf : IEntityTypeConfiguration<AcertoDespesas>
    {
        public void Configure(EntityTypeBuilder<AcertoDespesas> etd)
        {
            etd.ToTable("AcertoDespesas");
            etd.HasKey(c => c.AcertoDespId).HasName("PK_AcertoDespesas");
            etd.Property(c => c.AcertoDespId).HasColumnName("AcertoDespId").ValueGeneratedOnAdd();
            etd.Property(c => c.AcertoId).HasColumnName("AcertoId");
            etd.Property(c => c.AcertoId).HasColumnName("AcertoId");
            etd.Property(c => c.AcertoValDesp).HasColumnName("AcertoValDesp").HasColumnType("money");

            etd.HasOne(c => c.Acerto).WithMany(d => d.AcertoDespesas)
            .HasForeignKey(c => c.AcertoId).HasConstraintName("FK_Acerto_Despesas")
            .OnDelete(DeleteBehavior.NoAction);

            etd.HasIndex(c => new { c.AcertoId, c.AcertoDespId }).HasName("IDX_Acerto_AceDesp")
            .IsUnique();
        }

    }
}
