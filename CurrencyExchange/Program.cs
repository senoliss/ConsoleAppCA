using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace CurrencyExchange
{
    class CurrencyEx
    {
        static async Task Main(string[] args)
        {
            string[] supportedCurrencies = { "USD", "EUR", "GBP", "JPY" };

            Console.Write("Enter the source currency (USD, EUR, GBP, JPY): ");
            string sourceCurrency = Console.ReadLine().ToUpper();

            if (Array.IndexOf(supportedCurrencies, sourceCurrency) == -1)
            {
                Console.WriteLine("Invalid source currency.");
                return;
            }

            Console.Write("Enter the amount in the source currency: ");
            double sourceAmount = Convert.ToDouble(Console.ReadLine());

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"https://api.exchangeratesapi.io/latest?base={sourceCurrency}");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        var data = JsonSerializer.Deserialize<ExchangeRatesResponse>(responseBody, options);

                        foreach (string targetCurrency in supportedCurrencies)
                        {
                            if (targetCurrency != sourceCurrency)
                            {
                                double conversionRate = data.Rates[targetCurrency];
                                double targetAmount = sourceAmount * conversionRate;
                                Console.WriteLine($"Converted {sourceAmount} {sourceCurrency} to {targetAmount:F2} {targetCurrency} (Rate: {conversionRate:F4})");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error fetching exchange rates.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        public class ExchangeRatesResponse
        {
            public Dictionary<string, double> Rates { get; set; }
        }
    }

}
