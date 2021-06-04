using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes.Estoque
{
    public class DespesaConf : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> etd)
        {
            etd.ToTable("Despesas");
            etd.HasKey(c => c.DespesaId).HasName("PK_Despesas");
            etd.Property(c => c.DespesaId).HasColumnName("DespesaId").ValueGeneratedOnAdd();
            etd.Property(c => c.DespesaDesc).HasColumnName("DespesaDesc").HasMaxLength(100);
        }
    }
}
