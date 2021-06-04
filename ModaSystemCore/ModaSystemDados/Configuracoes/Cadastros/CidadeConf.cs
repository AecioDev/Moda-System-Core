using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class CidadeConf : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> etd)
        {
            etd.ToTable("Cidades");
            etd.HasKey(c => c.CidadeId).HasName("PK_Cidades");
            etd.Property(c => c.CidadeId).HasColumnName("CidadeId").ValueGeneratedOnAdd();
            etd.Property(c => c.CidadeIBGE).HasColumnName("CidadeIBGE");
            etd.Property(c => c.CidadeNome).HasColumnName("CidadeNome").HasMaxLength(100);
            etd.Property(c => c.CidadeEstado).HasColumnName("CidadeEstado").HasMaxLength(50);
            etd.Property(c => c.CidadeCodPais).HasColumnName("CidadeCodPais");

            etd.HasOne(c => c.Pais).WithMany(d => d.Cidades)
            .HasForeignKey(c => c.CidadeCodPais)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
