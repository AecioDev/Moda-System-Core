

using System.Collections.Generic;

namespace ModaSystemDomain.Entidades
{
    public class Socios
    {
        public int SocioId { get; set; }
        public string SocioNome { get; set; }
        public string SocioCell { get; set; }
        public decimal SocioPerCom { get; set; }
        public decimal TotComReceb { get; set; } //Total de Comissões já recebidas
        public int SocioVeiculo { get; set; }

        public virtual Veiculo Veiculo { get; set; }

        public List<Acerto> Acerto { get; set; }


    }
}
