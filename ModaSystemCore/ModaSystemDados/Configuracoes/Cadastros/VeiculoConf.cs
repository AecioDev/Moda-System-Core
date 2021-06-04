using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class VeiculoConf : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> etd)
        {
            etd.ToTable("Veiculos");
            etd.HasKey(c => c.VeiculoId).HasName("PK_Veiculos");
            etd.Property(c => c.VeiculoId).HasColumnName("VeiculoId").ValueGeneratedOnAdd();
            etd.Property(c => c.VeiculoDesc).HasColumnName("VeiculoDesc").HasMaxLength(100);
            etd.Property(c => c.VeiculoModelo).HasColumnName("VeiculoModelo").HasMaxLength(100);
            etd.Property(c => c.VeiculoMarca).HasColumnName("VeiculoMarca");
            etd.Property(c => c.VeiculoAno).HasColumnName("VeiculoAno");
            etd.Property(c => c.VeiculoStatus).HasColumnName("VeiculoStatus").HasColumnType("char").HasMaxLength(1);
            etd.Property(c => c.VeiculoObs).HasColumnName("VeiculoObs").HasMaxLength(1000);
        }
    }
}
