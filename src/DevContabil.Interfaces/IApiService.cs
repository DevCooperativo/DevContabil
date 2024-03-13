namespace DevContabil.Interfaces;

public interface IApiService
{
    string Get();
    Task<string> GetAsync();

}
