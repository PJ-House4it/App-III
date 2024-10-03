namespace AppIII.Maui.Infrastructure.Services;

public interface IApiService
{
    public Task<T?> GetAsync<T>(string url);
    public Task<bool> PostAsync<T>(string url, T data);
    public Task<bool> PutAsync<T>(string url, T data);
    public Task<bool> DeleteAsync(string url);
}