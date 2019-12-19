
namespace ModaSystemDomain.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string ProdutoCodBar { get; set; }
        public string ProdutoStatus { get; set; }
        public string ProdutoNome { get; set; }        
        public int ProdutoCodMarca { get; set; }
        public int ProdutoCodUni { get; set; }
        public decimal ProdutoCusto { get; set; }
        public decimal ProdutoValor { get; set; }
        public string ProdutoUsaTP { get; set; }

        public virtual Marca Marca { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}

/*Para Produtos eu Posso criar uma tabela extra tio Fornecedores por Produto (ComprasPro) e pra cada compra 
 * Alimentar essa tabela a fim de saber o Custo Médio e Custo de Reposição bem como o histórico
 * de compras.
 */
