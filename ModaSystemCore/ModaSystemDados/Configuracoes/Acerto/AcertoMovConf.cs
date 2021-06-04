using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class AcertoMovConf : IEntityTypeConfiguration<AcertoMovResumo>
    {
        public void Configure(EntityTypeBuilder<AcertoMovResumo> etd)
        {
            etd.ToTable("AcertoMovResumo");
            etd.HasKey(c => c.AcertoMovId).HasName("PK_AcertoMov");
            etd.Property(c => c.AcertoMovId).HasColumnName("AcertoMovId").ValueGeneratedOnAdd();
            etd.Property(c => c.AcertoId).HasColumnName("AcertoId");
            etd.Property(c => c.MovValTotNEnt).HasColumnName("MovValTotNEnt").HasColumnType("money");
            etd.Property(c => c.MovValTotRSal).HasColumnName("MovValTotRSal").HasColumnType("money");
            etd.Property(c => c.MovValTotDev).HasColumnName("MovValTotDev").HasColumnType("money");
            
            etd.HasIndex(c => new { c.AcertoId, c.AcertoMovId }).HasName("IDX_Acerto_AceMov")
            .IsUnique();
        }
    }
}
