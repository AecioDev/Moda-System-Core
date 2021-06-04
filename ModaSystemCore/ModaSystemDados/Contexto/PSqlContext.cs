using Microsoft.EntityFrameworkCore;
using ModaSystemDados.Configuracoes;
using ModaSystemDomain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModaSystemDados.Contexto
{
    public class PSqlContext : DbContext
    {
        public PSqlContext(DbContextOptions<PSqlContext> options) 
            : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("modacore");

            //Cadastros
            modelBuilder.ApplyConfiguration(new PaisConf());
            modelBuilder.ApplyConfiguration(new CidadeConf());
            modelBuilder.ApplyConfiguration(new SociosConf());
            modelBuilder.ApplyConfiguration(new TerceiroConf());
            modelBuilder.ApplyConfiguration(new VeiculoConf());

            //Acertos
            modelBuilder.ApplyConfiguration(new AcertoConf());
            modelBuilder.ApplyConfiguration(new AcertoDespConf());
            modelBuilder.ApplyConfiguration(new AcertoMovConf());
        }

        //Cadastros
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Socios> Socios { get; set; }
        public DbSet<Terceiro> Terceiro { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }

        //Acerto
        public DbSet<Acerto> Acerto { get; set; }
        public DbSet<AcertoDespesas> AcertoDesp { get; set; }
        public DbSet<AcertoMovResumo> AcertoMov { get; set; }
    }
}
