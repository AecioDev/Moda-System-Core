
using System.Collections.Generic;

namespace ModaSystemDomain.Entidades
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public int CidadeIBGE { get; set; }
        public string CidadeNome { get; set; }
        public string CidadeEstado { get; set; }
        public int CidadeCodPais { get; set; }

        public IEnumerable<Pais> Paises { get; }
    }
}
