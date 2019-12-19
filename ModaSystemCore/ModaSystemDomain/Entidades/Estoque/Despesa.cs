
namespace ModaSystemDomain.Entidades
{
    public class Despesa
    {
        public int DespesaId { get; set; }
        public string DespesaTipo { get; set; }
        public string DespesaDesc { get; set; }

        public virtual TipDesp TipDesp { get; set; }
    }
}
