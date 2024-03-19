using System.Text;
using DevContabil.Interfaces;

namespace DevContabil.Services;

public class NFApiService(HttpClient nfApiClient) : INFApiService
{

    private readonly HttpClient _nfApiClient = nfApiClient;

    #region NotaFiscalDeServico

    #region GetEmpresaByIdAsync
    public async Task<string> GetEmpresaByIdAsync(string id)
    {
        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfse.io/v2/companies/{id}"),
            Method = HttpMethod.Get
        };
        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetAllEmpresaAsync
    public async Task<string> GetAllEmpresaAsync()
    {
        var request = new HttpRequestMessage
        {
            RequestUri = new Uri("https://api.nfse.io/v2/companies"),
            Method = HttpMethod.Get
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetNotaFiscalByIdAsync
    public async Task<string> GetNotaFiscalByIdAsync(string companyId, string id)
    {


        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/serviceinvoices/{id}"),
            Method = HttpMethod.Get
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetAllNotaFicalAsync
    public async Task<string> GetAllNotaFiscalAsync(string companyId)
    {

        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/serviceinvoices"),
            Method = HttpMethod.Get
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region PostNotaFiscalAsync
    public async Task<string> PostNotaFiscalAsync(string companyId, string requestBody)
    {
        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/serviceinvoices"),
            Method = HttpMethod.Post
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");
        var bodyString = "{\r  \"borrower\": {\r    \"type\": \"Undefined\",\r    \"name\": \"string\",\r    \"federalTaxNumber\": 0,\r    \"municipalTaxNumber\": \"string\",\r    \"taxRegime\": \"Isento\",\r    \"email\": \"string\",\r    \"address\": {\r      \"country\": \"BRA\",\r      \"postalCode\": \"string\",\r      \"street\": \"string\",\r      \"number\": \"string\",\r      \"additionalInformation\": \"string\",\r      \"district\": \"string\",\r      \"city\": {\r        \"code\": \"3201209\",\r        \"name\": \"ES\"\r      },\r      \"state\": \"ES\"\r    }\r  },\r  \"cityServiceCode\": \"string\",\r  \"federalServiceCode\": \"string\",\r  \"cnaeCode\": \"string\",\r  \"description\": \"string\",\r  \"servicesAmount\": 0,\r  \"rpsSerialNumber\": \"string\",\r  \"issuedOn\": \"2024-03-15T22:41:56.446Z\",\r  \"rpsNumber\": 1,\r  \"taxationType\": \"None\",\r  \"issRate\": 0,\r  \"issTaxAmount\": 0,\r  \"deductionsAmount\": 0,\r  \"discountUnconditionedAmount\": 0,\r  \"discountConditionedAmount\": 0,\r  \"irAmountWithheld\": 0,\r  \"pisAmountWithheld\": 0,\r  \"cofinsAmountWithheld\": 0,\r  \"csllAmountWithheld\": 0,\r  \"inssAmountWithheld\": 0,\r  \"issAmountWithheld\": 0,\r  \"othersAmountWithheld\": 0,\r  \"approximateTax\": {\r    \"source\": \"string\",\r    \"version\": \"string\",\r    \"totalRate\": 0\r  },\r  \"additionalInformation\": \"string\",\r  \"location\": {\r    \"state\": \"ES\",\r    \"city\": {\r      \"code\": \"3201209\",\r      \"name\": \"ES\"\r    }\r  }\r}";
        var content = new StringContent(bodyString, Encoding.UTF8, "application/json");
        request.Content = content;

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;

    }
    #endregion

    #region DeleteNotaFiscalAsync
    public async Task<string> DeleteNotaFiscalAsync(string companyId, string id)
    {
        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/serviceinvoices/{id}"),
            Method = HttpMethod.Delete
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetNotaFiscalByIdToPdfAsync
    public async Task<string> GetNotaFiscalByIdToPdfAsync(string companyId, string id)
    {
        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/serviceinvoices/{id}/pdf"),
            Method = HttpMethod.Get
        };
        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetNotaFiscalByIdToXmlAsync
    public async Task<string> GetNotaFiscalByIdToXmlAsync(string companyId, string id)
    {

        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/serviceinvoices/{id}/xml"),
            Method = HttpMethod.Get
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetPessoaFisicaByIdAsync
    public async Task<string> GetPessoaFisicaByIdAsync(string companyId, string id)
    {

        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/naturalpeople/{id}"),
            Method = HttpMethod.Get
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetAllPessoaFisicaAsync
    public async Task<string> GetAllPessoaFisicaAsync(string companyId)
    {

        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/naturalpeople"),
            Method = HttpMethod.Get
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetPessoaJuridicaByIdAsync
    public async Task<string> GetPessoaJuridicaByIdAsync(string companyId, string id)
    {
        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/legalpeople/{id}"),
            Method = HttpMethod.Get
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion

    #region GetAllPessoaJuridicaAsync
    public async Task<string> GetAllPessoaJuridicaAsync(string companyId)
    {
        var request = new HttpRequestMessage
        {
            RequestUri = new Uri($"https://api.nfe.io/v1/companies/{companyId}/legalpeople"),
            Method = HttpMethod.Get
        };

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("Authorization", "C3ZDjVfkUaXmy7iBf6OH8CERTB1B5uk6hdY0JRLKicdFEoLFTDSD01ZgInvLFagrZrx");

        var response = await _nfApiClient.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
    #endregion


    #endregion

    #region NotaFiscalDeProduto

    #endregion

}
