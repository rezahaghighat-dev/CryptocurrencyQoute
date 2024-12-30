using App.Domain.Core.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace App.Infra.ExternalServices.CoinMarketCapAPI
{
    public class CurrencyInfoRepository : ICurrencyInfoRepository
    {
        private readonly CoinMarketCapAPIConfig _config;
        private readonly HttpClient _httpClient;

        public CurrencyInfoRepository(CoinMarketCapAPIConfig config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<string> GetCurrencyPriceWithBaseAUD(string currency)
        {
            var URL = new UriBuilder(_config.LatestQoutesURL);
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["symbol"] = currency;
            queryString["convert"] = "AUD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", _config.API_KEY);
            client.Headers.Add("Accepts", "application/json");

            var jsonResult = await client.DownloadStringTaskAsync(URL.ToString());
            var parsedResult = JsonConvert.DeserializeObject(jsonResult);
            return JsonConvert.SerializeObject(parsedResult, Formatting.Indented);
        }

        public async Task<string> GetCurrencyPriceWithBaseBRL(string currency)
        {
            var URL = new UriBuilder(_config.LatestQoutesURL);
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["symbol"] = currency;
            queryString["convert"] = "BRL";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", _config.API_KEY);
            client.Headers.Add("Accepts", "application/json");

            var jsonResult = await client.DownloadStringTaskAsync(URL.ToString());
            var parsedResult = JsonConvert.DeserializeObject(jsonResult);
            return JsonConvert.SerializeObject(parsedResult, Formatting.Indented);
        }

        public async Task<string> GetCurrencyPriceWithBaseEUR(string currency)
        {
            var URL = new UriBuilder(_config.LatestQoutesURL);
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["symbol"] = currency;
            queryString["convert"] = "EUR";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", _config.API_KEY);
            client.Headers.Add("Accepts", "application/json");

            var jsonResult = await client.DownloadStringTaskAsync(URL.ToString());
            var parsedResult = JsonConvert.DeserializeObject(jsonResult);
            return JsonConvert.SerializeObject(parsedResult, Formatting.Indented);
        }

        public async Task<string> GetCurrencyPriceWithBaseGBP(string currency)
        {
            var URL = new UriBuilder(_config.LatestQoutesURL);
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["symbol"] = currency;
            queryString["convert"] = "GBP";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", _config.API_KEY);
            client.Headers.Add("Accepts", "application/json");

            var jsonResult = await client.DownloadStringTaskAsync(URL.ToString());
            var parsedResult = JsonConvert.DeserializeObject(jsonResult);
            return JsonConvert.SerializeObject(parsedResult, Formatting.Indented);
        }

        public async Task<string> GetCurrencyPriceWithBaseUSD(string currency)
        {
            var URL = new UriBuilder(_config.LatestQoutesURL);
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["symbol"] = currency;
            queryString["convert"] = "USD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", _config.API_KEY);
            client.Headers.Add("Accepts", "application/json");

            var jsonResult = await client.DownloadStringTaskAsync(URL.ToString());
            var parsedResult = JsonConvert.DeserializeObject(jsonResult);
            return JsonConvert.SerializeObject(parsedResult, Formatting.Indented);
        }
    }
}
