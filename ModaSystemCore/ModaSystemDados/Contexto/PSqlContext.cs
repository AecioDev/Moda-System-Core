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
        public PSqlContext(DbContextOptions<PSqlContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder constModel)
        {
                        
            constModel.UseIdentityColumns();
            constModel.HasDefaultSchema("modacore");

            PaisConf.ConfiguraPais(constModel);
            CidadeConf.ConfiguraCidade(constModel);
        }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}
