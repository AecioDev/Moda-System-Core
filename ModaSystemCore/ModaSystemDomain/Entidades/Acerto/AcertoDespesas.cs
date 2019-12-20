
namespace ModaSystemDomain.Entidades
{
    public class AcertoDespesas
    {
        public int AcertoId { get; set; }
        public int AcertoDespId { get; set; }        
        public decimal AcertoValDesp { get; set; }

        public virtual Despesa Despesa { get; set; }
    }
}
