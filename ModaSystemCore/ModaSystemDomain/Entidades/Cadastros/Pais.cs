using System.Collections.Generic;

namespace ModaSystemDomain.Entidades
{
    public class Pais
    {
        public int CodPaisBacen { get; set; }
        public string NomePaisBacen { get; set; }

        public List<Cidade> Cidades { get; set; }
    }
}
