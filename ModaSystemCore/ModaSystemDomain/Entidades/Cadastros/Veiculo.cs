﻿using System.Collections.Generic;

namespace ModaSystemDomain.Entidades
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string VeiculoDesc { get; set; }
        public int VeiculoMarca { get; set; }
        public string VeiculoModelo { get; set; }
        public int VeiculoAno { get; set; }
        public string VeiculoStatus { get; set; }
        public string VeiculoObs { get; set; }

        public List<Socios> Socios { get; set; }
        public List<Acerto> Acerto { get; set; }
    }
}
