
using System.Collections.Generic;

namespace ModaSystemDomain.Entidades
{
    public class Despesa
    {
        public int DespesaId { get; set; }
        public string DespesaDesc { get; set; }

        public List<AcertoDespesas> AcertoDesp { get; set; }        
    }
}
