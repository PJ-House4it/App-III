using System.Net.Http.Json;

namespace AppIII.Maui.Infrastructure.Services;

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T?> GetAsync<T>(string url)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<T>();
        }
        
        throw new HttpRequestException($"Error fetching data: {response.ReasonPhrase}");
    }

    public async Task<bool> PostAsync<T>(string url, T data)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, data);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> PutAsync<T>(string url, T data)
    {
        HttpResponseMessage response = await _httpClient.PutAsJsonAsync(url, data);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(string url)
    {
        HttpResponseMessage response = await _httpClient.DeleteAsync(url);
        return response.IsSuccessStatusCode;
    }
}