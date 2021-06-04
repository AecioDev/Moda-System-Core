using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class TerceiroConf : IEntityTypeConfiguration<Terceiro>
    {
        public void Configure(EntityTypeBuilder<Terceiro> etd)
        {
            etd.ToTable("Terceiros");
            etd.HasKey(c => c.TerceiroId).HasName("PK_Terceiros");
            etd.Property(c => c.TerceiroId).HasColumnName("TerceiroId").ValueGeneratedOnAdd();
            etd.Property(c => c.TerceiroTipo).HasColumnName("TerceiroTipo").HasColumnType("char").HasMaxLength(1);
            etd.Property(c => c.TerceiroNome).HasColumnName("TerceiroNome").HasMaxLength(100);
            etd.Property(c => c.TerceiroTel).HasColumnName("TerceiroTel").HasMaxLength(15);
            etd.Property(c => c.TerceiroEmail).HasColumnName("TerceiroEmail").HasMaxLength(100);
            etd.Property(c => c.TerceiroCep).HasColumnName("TerceiroCep").HasMaxLength(8);
            etd.Property(c => c.TerceiroRua).HasColumnName("TerceiroRua").HasMaxLength(100);
            etd.Property(c => c.TerceiroNum).HasColumnName("TerceiroNum").HasMaxLength(10);
            etd.Property(c => c.TerceiroBairro).HasColumnName("TerceiroBairro").HasMaxLength(100);
            etd.Property(c => c.TerceiroComp).HasColumnName("TerceiroComp").HasMaxLength(100);
            etd.Property(c => c.TerceiroCidade).HasColumnName("TerceiroCidade");
            etd.HasOne(c => c.Cidade).WithMany(d => d.Terceiro)
            .HasForeignKey(c => c.TerceiroCidade)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
