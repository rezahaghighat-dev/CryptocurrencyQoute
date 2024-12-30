using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.ExternalServices.ExchaneRatesAPI
{
    public class ExchangeRateApiConfig
    {
        private static string ApiKey = "80816cccdb452b70e6d14535f366b55c";
        public const string BaseUrl = "https://api.exchangeratesapi.io/v1/";
        public string TestApiKey { get; set; } = "https://api.exchangeratesapi.io/v1/latest?access_key=80816cccdb452b70e6d14535f366b55c";
        public string LatestRatesEndPointWithBaseUSD { get; set; } = $"{BaseUrl}latest?access_key={ApiKey}&base=USD&symbols=";
        public string LatestRatesEndPointWithBaseEUR { get; set; } = $"{BaseUrl}latest?access_key={ApiKey}&base=EUR&symbols=";
        public string LatestRatesEndPointWithBaseBRL { get; set; } = $"{BaseUrl}latest?access_key={ApiKey}&base=BRL&symbols=";
        public string LatestRatesEndPointWithBaseGBP { get; set; } = $"{BaseUrl}latest?access_key={ApiKey}&base=GBP&symbols=";
        public string LatestRatesEndPointWithBaseAUD { get; set; } = $"{BaseUrl}latest?access_key={ApiKey}&base=AUD&symbols=";
    }
}
