using Microsoft.EntityFrameworkCore;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class PaisConf
    {
        public static void ConfiguraPais(ModelBuilder constModel)
        {
            constModel.Entity<Pais>(etd =>
            {
                etd.ToTable("Paises");
                etd.HasKey(c => c.CodPaisBacen).HasName("CodPaisBacen");
                etd.Property(c => c.CodPaisBacen).HasColumnName("CodPaisBacen").ValueGeneratedOnAdd();
                etd.Property(c => c.NomePaisBacen).HasColumnName("NomePaisBacen").HasMaxLength(40);
            });
        }
    }
}
