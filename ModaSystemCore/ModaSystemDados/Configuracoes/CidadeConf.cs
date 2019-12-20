using Microsoft.EntityFrameworkCore;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class CidadeConf
    {
        public static void ConfiguraCidade(ModelBuilder constModel)
        {
            constModel.Entity<Cidade>(etd =>
            {
                etd.ToTable("Cidades");
                etd.HasKey(c => c.CidadeId).HasName("CidadeId");
                etd.Property(c => c.CidadeIBGE).HasColumnName("CidadeIBGE");
                etd.Property(c => c.CidadeNome).HasColumnName("CidadeNome").HasMaxLength(100);
                etd.Property(c => c.CidadeEstado).HasColumnName("CidadeEstado").HasMaxLength(50);
                etd.HasMany(c => c.Paises).WithOne(c => c.Cidade).HasForeignKey("CidadeCodPais");
            });
        }
    }
}
