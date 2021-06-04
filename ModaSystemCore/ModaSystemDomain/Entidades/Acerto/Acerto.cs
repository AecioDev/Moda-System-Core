
using System;
using System.Collections.Generic;

namespace ModaSystemDomain.Entidades
{
    public class Acerto
    {
        public int AcertoId { get; set; }
        public int AcertoSocio { get; set; }
        public int AcertoVeiculo { get; set; }
        public int AcertoMes { get; set; }
        public int AcertoAno { get; set; }
        public DateTime AcertoData { get; set; }
        public string AcertoObs { get; set; }

        //PRODUTOS
        public decimal QntMercEntregue { get; set; }
        public decimal ValTotEntregue { get; set; }
        public decimal ValTotDevolvidas { get; set; }
        public decimal ValTotVendidas { get; set; }

        //Cobranças no Estado de MS
        public decimal QntTotFichas { get; set; }
        public decimal ValTotFichas { get; set; }

        //Resumo Fechamento
        public decimal ValTotReceitas { get; set; }
        public decimal ValTotDespesas { get; set; }

        //Pagamento
        public decimal ValSaldoFinal { get; set; }
        public decimal PercPagSocio { get; set; }
        public decimal ValPagSocio { get; set; }
        public decimal PercPagEmpresa { get; set; }
        public decimal ValPagEmpresa { get; set; }

        public virtual Socios Socios { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public List<AcertoDespesas> AcertoDespesas { get; set; }
        public AcertoMovResumo AcertoResumo { get; set; }
        //public virtual AcertoProdutos AcertoProdutos { get; set; }

    }
}
