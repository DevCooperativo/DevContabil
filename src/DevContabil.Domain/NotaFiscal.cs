using System;

namespace DevContabil.Domain;

public class NotaFiscal{
    public int idNotaFiscal { get; set; }
    public string cnpjCredor { get; set; }
    public string cnpjDevedor { get; set; }
    public decimal valor { get; set; }    
    public string status { get; set; }

    public DateTime dataEmissao { get; set; }
    public DateTime dataFechamento { get; set; }
}