using System;

namespace ModaSystemDomain.Entidades
{
    public class MovEntrada
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
        
    }
}
