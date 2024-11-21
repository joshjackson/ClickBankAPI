using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ClickBankAPI;

namespace ClickBankTestApp {

    class Program {
        static async Task Main(string[] args) {
            string apiKey = "your-api-key-here"; // Replace with your API key
            var client = new ClickBankApiClient(apiKey);

            // Fetch order data with optional query parameters
            var orderData = await client.GetOrderDataAsync("status=active");

            if (orderData != null) {
                Console.WriteLine($"Transaction Time: {orderData.TransactionTime}");
                Console.WriteLine($"Receipt: {orderData.Receipt}");
                Console.WriteLine($"Total Order Amount: {orderData.TotalOrderAmount}");
                // Add additional fields as needed
            } else {
                Console.WriteLine("No order data found.");
            }
        }


    }
}