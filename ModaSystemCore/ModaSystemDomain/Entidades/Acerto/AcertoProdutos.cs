﻿
using System.Collections.Generic;

namespace ModaSystemDomain.Entidades
{
    public class AcertoProdutos
    {
        public int AcertoId { get; set; }
        public int AcertoProId { get; set; }
        public decimal AcertoQntPro { get; set; }
        public decimal AcertoCusPro { get; set; }
        public decimal AcertoValPro { get; set; }

        public virtual Produto Produto { get; set; }
        public List<Acerto> Acerto { get; set; }
    }
}
