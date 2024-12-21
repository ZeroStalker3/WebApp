using System.Text;
using System.Text.Json;

namespace WebApp.Services
{
    public class ApiService<T> where T : class
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public ApiService(string apiUrl)
        {
            _httpClient = new HttpClient();
            _apiUrl = apiUrl;
        }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        try
        {
            var response = await _httpClient.GetStringAsync(_apiUrl);
            
            var result = JsonSerializer.Deserialize<IEnumerable<T>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Игнорирует регистр имён свойств
            });
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during deserialization: {ex.Message}");
            return null; // Или выбросьте исключение
        }
    }


        public async Task<T> GetAsync(int id)
        {
            var response = await _httpClient.GetStringAsync($"{_apiUrl}/{id}");
            return JsonSerializer.Deserialize<T>(response);
        }

        public async Task<T> CreateAsync(T item)
        {
            var json = JsonSerializer.Serialize(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_apiUrl, content);

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseBody);
        }

        public async Task<T> UpdateAsync(int id, T item)
        {
            var json = JsonSerializer.Serialize(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{_apiUrl}/{id}", content);

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseBody);
        }

        public async Task DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_apiUrl}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}