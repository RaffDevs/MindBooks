using mind_book_api.Models;
using mind_book_api.Shared.Enums;
using mind_book_api.Shared.Extensions;
using System.Text.Json;

namespace mind_book_api.Services
{
    public class GoogleBooksService
    {
        private readonly string _baseUrl = "https://www.googleapis.com";
        private readonly string _route = "books/v1/volumes";
        private readonly string _apiKey;

        private readonly HttpClient _httpClient;

        public GoogleBooksService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _apiKey = Environment.GetEnvironmentVariable("APIKEY");
        }

        public async Task<GoogleBook?> SearchBooks(SearchBookParams searchParam, string name)
        {
            string searchUriParam = searchParam.ToLowerCaseString();
            string valueUriParam = Uri.EscapeDataString(name);

            UriBuilder uriBuilder = new UriBuilder(_baseUrl)
            {
                Path = _route,
                Query = $"q={searchUriParam}:{valueUriParam}&key={_apiKey}"
            };

            try
            {
                var response = await _httpClient.GetAsync(uriBuilder.Uri);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonSerializer.Deserialize<GoogleBook>(jsonString);
                    return jsonObject;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro na requisição: {ex.Message}");
                throw;
            }

            return null;
        }
    }

}
