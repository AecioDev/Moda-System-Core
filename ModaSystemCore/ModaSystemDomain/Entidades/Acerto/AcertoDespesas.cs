
using System.Collections.Generic;

namespace ModaSystemDomain.Entidades
{
    public class AcertoDespesas
    {
        public int AcertoDespId { get; set; }
        public int AcertoId { get; set; }
        public int CodDespesa { get; set; }
        public decimal AcertoValDesp { get; set; }

        public virtual Acerto Acerto { get; set; }
        public virtual AcertoDespesas AcertoDesp { get; set; }
    }
}
