using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class PaisConf : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> etd)
        {
            etd.ToTable("Paises");
            etd.HasKey(c => c.CodPaisBacen).HasName("PK_CodPais");
            etd.Property(c => c.CodPaisBacen).HasColumnName("CodPaisBacen").ValueGeneratedOnAdd();
            etd.Property(c => c.NomePaisBacen).HasColumnName("NomePaisBacen").HasMaxLength(40);
        }
    }
}
