using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class AcertoProdutoConf : IEntityTypeConfiguration<AcertoProdutos>
    {
        public void Configure(EntityTypeBuilder<AcertoProdutos> etd)
        {
            etd.ToTable("AcertoProdutos");
            etd.HasKey(c => c.AcertoId).HasName("AcertoId");
            etd.HasKey(c => c.AcertoProId).HasName("AcertoProId");
            etd.Property(c => c.AcertoProId).HasColumnName("AcertoProId").ValueGeneratedOnAdd();
            etd.Property(c => c.AcertoQntPro).HasColumnName("AcertoQntPro").HasColumnType("money");
            etd.Property(c => c.AcertoCusPro).HasColumnName("AcertoCusPro").HasColumnType("money");
            etd.Property(c => c.AcertoValPro).HasColumnName("AcertoValPro").HasColumnType("money");

        }
    }
}
