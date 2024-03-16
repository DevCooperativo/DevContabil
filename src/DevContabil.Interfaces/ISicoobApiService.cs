namespace DevContabil.Interfaces;

public interface ISicoobApiService
{
    string Get();
    Task<string> GetAsync();

}
