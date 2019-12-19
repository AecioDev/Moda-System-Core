
namespace ModaSystemDomain.Entidades
{
    public class AcertoMovResumo
    {
        public int AcertoId { get; set; }
        public int AcertoDevId { get; set; }
        public decimal MovValTotEnt { get; set; }
        public decimal MovValTotNaoEnt { get; set; }
        public decimal MovValTotRetSalao { get; set; }
    }
}

/*Existe um outro Nível que são os produtos que foram movimentados para gerar esses valores totais.
 * Nesse caso seria bom criar uma estrutura separada para movimentação de mercadorias durante o período 
 * de vendas que geralmente são 2 meses.
 *  Tabela Principal - Movimentacao
 *  Criar Tipos:
 *      SaidasProdutos      'S'
 *      EntradasProdutos    'E'
 *      DevolucaoProdutos   'D'
 *
 * Entrada de Produtos - 'E'
 *  Essa Movimentação será utilizada para alimentar o estoque do salão principal onde são armazenadas as
 * mercadorias na firma.
 * 
 * Saídas de Produtos - 'S'
 *  Essa Movimentação será a responsável por carregar o carro do vendedor com as mercadorias que ele irá
 * entregar para as vendedoras venderem
 * 
 *  A Partir dessa Movimentação será criada a Movimentação da Vendedora. 
 * Quando o Socio Lançar uma Ficha e Deixar os Produtos com a vendedora, deve ocorrer uma Movimentação 
 * Saindo a mercadoria do Carro e deixando a ficha com status "Aguardando Cobrança".
 * 
 *  Quando o Sócio For Cobrar essa Vendedora deverá lançar no sistema o código da Ficha da Vendedora que 
 * vai estar em aberto "Aguardando Cobrança" e ele deverá pagar as mercadorias que ela vendeu, e devolvar
 * as mercadorias que ela não vendeu. Essas que ela não vendeu vão voltar para o estoque do carro, e essas
 * fichas serão finalizadas. 
 * 
 *  Para a Vendedora continuar com as peças que não foram vendidas o socio deverá gerar uma nova ficha
 * colocando novamente os produtos q ela não vendeu e os produtos a mais que ela possa pegar para vender,
 * e novamente a ficha vai ficar "Aguardando Cobrança" esperando a próxima cobrança do mes. 
 * 
 * Falta ver como que funciona as Devoluções e a parte de Não Entregues se isso fica no Carro ou se ele 
 * Devolve para o salão.
 * 
 */
