using System.Threading;

namespace DevContabil.Services;

public class ApiService
{
    public string Get()
    {
        return "Hello World!";
    }

    public async Task<string> GetAsync()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage();
        request.RequestUri = new Uri("https://sandbox.sicoob.com.br/sicoob/sandbox/cobranca-bancaria/v2/boletos?numeroContrato=1&modalidade=1");
        request.Method = HttpMethod.Get;

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");
        request.Headers.Add("client_id", "9b5e603e428cc477a2841e2683c92d21");
        request.Headers.Add("Authorization", "Bearer 1301865f-c6bc-38f3-9f49-666dbcfc59c3");

        var response = await client.SendAsync(request);
        var result = await response.Content.ReadAsStringAsync();
        return result;
    }
}