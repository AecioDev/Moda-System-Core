using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class SociosConf : IEntityTypeConfiguration<Socios>
    {
        public void Configure(EntityTypeBuilder<Socios> etd)
        {
            etd.ToTable("Socios");
            etd.HasKey(c => c.SocioId).HasName("PK_Socios");
            etd.Property(c => c.SocioId).HasColumnName("SocioId").ValueGeneratedOnAdd();
            etd.Property(c => c.SocioNome).HasColumnName("SocioNome").HasMaxLength(100);
            etd.Property(c => c.SocioCell).HasColumnName("SocioCell").HasMaxLength(15);
            etd.Property(c => c.SocioPerCom).HasColumnName("SocioPerCom").HasColumnType("money");
            etd.Property(c => c.SocioVeiculo).HasColumnName("SocioVeiculo");
            etd.HasOne(c => c.Veiculo).WithMany(d => d.Socios)
            .HasForeignKey(c => c.SocioVeiculo)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
