using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProtesto.Models
{
    public class Protesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Int32 CodigoBanco { get; set; }
        public long CodigoInterno { get; set; }
        public string NomeCredor { get; set; }
        public long NumeroTitulo { get; set; }
        public Int32 Parcela { get; set; }
        public string NomeDevedor { get; set; }
        public string CPF_CNPJ_Devedor { get; set; }
        public string Endereco_Devedor { get; set; }
        public string Bairro_Devedor { get; set; }
        public string Cidade_Devedor { get; set; }
        public long CEP_Devedor { get; set; }
        public string UF_Devedor { get; set; }
        public string Cidade_Praca_Pagamento { get; set; }
        public string UF_Praca_Pagamento { get; set; }
        public double ValorTitulo { get; set; }
        public double ValorProtestar { get; set; }
        public string DataEmissao { get; set; }
        public string DataVencimento { get; set; }
        public string TipoDocumento { get; set; }
        public string Operacao { get; set; }
        public double Valor1aParcela { get; set; }
        public Int32 QtdeParcelaContrato { get; set; }
        public string Status { get; set; }
    }
}
