namespace DevContabil.Interfaces;

public interface INFApiService
{
    #region NotaFiscalDeServico

    Task<string> GetAllEmpresaAsync();
    Task<string> GetEmpresaByIdAsync(string id);
    Task<string> GetNotaFiscalByIdAsync(string companyId, string id);
    Task<string> GetAllNotaFiscalAsync(string companyId);
    Task<string> PostNotaFiscalAsync(string companyId, string requestBody);
    Task<string> DeleteNotaFiscalAsync(string companyId, string id);
    Task<string> GetNotaFiscalByIdToPdfAsync(string companyId, string id);
    Task<string> GetNotaFiscalByIdToXmlAsync(string companyId, string id);
    Task<string> GetPessoaFisicaByIdAsync(string companyId, string id);
    Task<string> GetAllPessoaFisicaAsync(string companyId);
    Task<string> GetPessoaJuridicaByIdAsync(string companyId, string id);
    Task<string> GetAllPessoaJuridicaAsync(string companyId);

    #endregion
}
