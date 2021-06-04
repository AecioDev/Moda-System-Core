using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaSystemDomain.Entidades;

namespace ModaSystemDados.Configuracoes
{
    public class AcertoConf : IEntityTypeConfiguration<Acerto>
    {
        public void Configure(EntityTypeBuilder<Acerto> etd)
        {
            etd.ToTable("Acerto");

            //Cabeçalho
            etd.HasKey(c => c.AcertoId).HasName("PK_Acertos");
            etd.Property(c => c.AcertoId).HasColumnName("AcertoId").ValueGeneratedOnAdd();
            etd.Property(c => c.AcertoSocio).HasColumnName("AcertoSocio");
            etd.Property(c => c.AcertoVeiculo).HasColumnName("AcertoVeiculo");
            etd.Property(c => c.AcertoMes).HasColumnName("AcertoMes");
            etd.Property(c => c.AcertoAno).HasColumnName("AcertoAno");
            etd.Property(c => c.AcertoData).HasColumnName("AcertoData");
            etd.Property(c => c.AcertoObs).HasColumnName("AcertoObs").HasMaxLength(1000);

            //Produtos / Mercadorias Entregues
            etd.Property(c => c.QntMercEntregue).HasColumnName("QntMercEntregue").HasColumnType("money");
            etd.Property(c => c.ValTotEntregue).HasColumnName("ValTotEntregue").HasColumnType("money");
            etd.Property(c => c.ValTotDevolvidas).HasColumnName("ValTotDevolvidas").HasColumnType("money");
            etd.Property(c => c.ValTotVendidas).HasColumnName("ValTotVendidas").HasColumnType("money");

            //Cobranças no Estado de MS
            etd.Property(c => c.QntTotFichas).HasColumnName("QntTotFichas").HasColumnType("money");
            etd.Property(c => c.ValTotFichas).HasColumnName("ValTotFichas").HasColumnType("money");

            //Resumo Fechamento
            etd.Property(c => c.ValTotReceitas).HasColumnName("ValTotReceitas").HasColumnType("money");
            etd.Property(c => c.ValTotDespesas).HasColumnName("ValTotDespesas").HasColumnType("money");
            etd.Property(c => c.ValSaldoFinal).HasColumnName("ValSaldoFinal").HasColumnType("money");

            //Pagamento
            etd.Property(c => c.PercPagSocio).HasColumnName("PercPagSocio").HasColumnType("money");
            etd.Property(c => c.ValPagSocio).HasColumnName("ValPagSocio").HasColumnType("money");
            etd.Property(c => c.PercPagEmpresa).HasColumnName("PercPagEmpresa").HasColumnType("money");
            etd.Property(c => c.ValPagEmpresa).HasColumnName("ValPagEmpresa").HasColumnType("money");


            /* Relacionamentos
             *  Sócios
             *  Veículos
             *  AcertoDespesas
             */

            etd.HasOne(c => c.Socios).WithMany(d => d.Acerto)
            .HasForeignKey(c => c.AcertoSocio)
            .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.Veiculo).WithMany(d => d.Acerto)
            .HasForeignKey(c => c.AcertoVeiculo)
            .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.AcertoResumo).WithOne(d => d.Acerto)
            .HasForeignKey<AcertoMovResumo>(d => d.AcertoId)
            .OnDelete(DeleteBehavior.NoAction);
        }        
    }
}
