
namespace ModaSystemDomain.Entidades
{
    public class Pais
    {
        public int CodPaisBacen { get; set; }
        public string NomePaisBacen { get; set; }

        public Cidade Cidade { get; set; }
    }
}
