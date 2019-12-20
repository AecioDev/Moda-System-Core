
namespace ModaSystemDomain.Entidades
{
    public class MovProduto
    {
        public int MovimentoId { get; set; }
        public int MovCodPro { get; set; }
        public decimal MovQntPro { get; set; }
        public decimal MovCusPro { get; set; }
        public decimal MovValUniPro { get; set; }
        public decimal MovValTotPro { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
