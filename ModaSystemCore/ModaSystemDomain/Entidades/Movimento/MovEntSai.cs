﻿using System;

namespace ModaSystemDomain.Entidades
{
    /// <summary>
    /// Essa rotina será usada nas:
    ///     Entradas de Mercadorias (Compras)
    ///     Saidas de Mercadorias para o Carro dos Sócios
    ///     Entradas de Mercadorias do Sócio como Devoluções
    /// </summary>
    public class MovEntSai
    {
        public int MovimentoId { get; set; }
        public DateTime MovDatEmissao { get; set; }
        public DateTime MovDataEntSai { get; set; }     //Data da Entrada ou Saída
        public DateTime MovDataDig { get; set; }        //Data Digitação        
        public string MovTipo { get; set; }             //Tipo de Movimento - Entrada: 'E', Saída: 'S' ou Devolução 'D'
        public int MovSocio { get; set; }
        public int MovTerceiro { get; set; }            //Terceiro do Tipo Fornecedor essa rotina só terá Sócio ou Fornecedor 
        public string MovNumero { get; set; }
        public string MovStatus { get; set; }
        public string MovObservacao { get; set; }

        public decimal MovValBruto { get; set; }   
        public decimal MovValTotPro { get; set; }  
        public decimal MovValTotOut { get; set; }  
        public decimal MovValTotDesc { get; set; } 
        public decimal MovValLiquido { get; set; }

        public virtual Socios Socios { get; set; }
        public virtual Terceiro Terceiro { get; set; }

    }
}
