// File: ApiClient.cs
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClickBankAPI {
    public class ClickBankApiClient {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "https://api.clickbank.com/rest/1.3/orders2";

        public ClickBankApiClient(string apiKey) {
            // Initialize HttpClient with default headers
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", apiKey);
        }

        /// <summary>
        /// Sends a GET request to the specified endpoint.
        /// </summary>
        /// <param name="queryParameters">Query parameters to append to the request URL.</param>
        /// <returns>Deserialized response data.</returns>
        public async Task<T?> GetAsync<T>(string queryParameters = "") {
            try {
                string url = $"{_apiBaseUrl}{(string.IsNullOrWhiteSpace(queryParameters) ? "" : $"?{queryParameters}")}";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(jsonResponse);
            } catch (Exception ex) {
                Console.WriteLine($"Error during GET request: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Sends a POST request to the specified endpoint with a JSON payload.
        /// </summary>
        /// <param name="payload">The object to be sent as JSON.</param>
        /// <typeparam name="TResponse">The expected response type.</typeparam>
        /// <returns>Deserialized response data.</returns>
        public async Task<TResponse?> PostAsync<TRequest, TResponse>(TRequest payload) {
            try {
                string jsonPayload = JsonSerializer.Serialize(payload);
                StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(_apiBaseUrl, content);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TResponse>(jsonResponse);
            } catch (Exception ex) {
                Console.WriteLine($"Error during POST request: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Releases the underlying HttpClient resources.
        /// </summary>
        public void Dispose() {
            _httpClient.Dispose();
        }
    }

    // Example Usage
    class Program {
        static async Task Main(string[] args) {
            string apiKey = "your-api-key-here"; // Replace with your API key
            var client = new ClickBankApiClient(apiKey);

/*            // Example: GET Request
            var orders = await client.GetAsync<OrderResponse>("status=active");
            Console.WriteLine($"Order ID: {orders?.OrderId}, Status: {orders?.Status}");

            // Example: POST Request
            var requestPayload = new OrderRequest { CustomerId = "12345", ProductId = "ABC123" };
            var response = await client.PostAsync<OrderRequest, OrderResponse>(requestPayload);
            Console.WriteLine($"Order ID: {response?.OrderId}, Status: {response?.Status}");
*/        
        }
    }
}