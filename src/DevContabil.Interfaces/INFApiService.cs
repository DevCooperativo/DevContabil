namespace DevContabil.Interfaces;

public interface INFApiService
{
    #region NotaFiscalDeServico

    Task<string> GetAllEmpresaAsync();
    Task<string> GetEmpresaByIdAsync(string id);
    Task<string> GetNotaFiscalByIdAsync(string companyId, string id);
    Task<string> GetAllNotaFiscalAsync(string companyId);
    Task<string> PostNotaFiscalAsync(string companyId);
    Task<string> DeleteNotaFiscalAsync(string companyId, string id);
    Task<string> GetNotaFiscalByIdToPdfAsync();
    Task<string> GetNotaFiscalByIdToXmlAsync();
    Task<string> GetPessoaFisicaByIdAsync();
    Task<string> GetAllPessoaFisicaAsync();
    Task<string> GetPessoaJuridicaByIdAsync();
    Task<string> GetAllPessoaJuridicaAsync();

    #endregion
}
