using Microsoft.EntityFrameworkCore;
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
    }
}
