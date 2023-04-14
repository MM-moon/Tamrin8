using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace CryptoPricePrediction
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string responseString = await client.GetStringAsync("https://api.kucoin.com/api/v1/market/stats?symbol=BTC-USDT");

            Dictionary<string, CurrencyStats> stats = JsonConvert.DeserializeObject<Dictionary<string, CurrencyStats>>(responseString);

            Console.ReadLine();
        }
    }

    public class CurrencyStats
    {
        public double price { get; set; }
        public double change24h { get; set; }
        public double volume24h { get; set; }
    }
}