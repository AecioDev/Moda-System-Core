
namespace ModaSystemDomain.Entidades
{
    public class Terceiro
    {
        public int TerceiroId { get; set; }
        public string TerceiroTipo { get; set; } //Fornecedor: 'F' ou Cliente: 'C', vendedoras das fichas
        public string TerceiroNome { get; set; }
        public string TerceiroTel { get; set; }
        public string TerceiroEmail { get; set; }
        public string TerceiroCep { get; set; }
        public string TerceiroRua { get; set; }
        public string TerceiroNum { get; set; }
        public string TerceiroBairro { get; set; }
        public string TerceiroComp { get; set; }
        public int TerceiroCidade { get; set; } //Código da Cidade

        public virtual Cidade Cidade { get; set; }

    }
}
