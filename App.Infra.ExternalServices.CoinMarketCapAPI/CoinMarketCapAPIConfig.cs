using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.ExternalServices.CoinMarketCapAPI
{
    public class CoinMarketCapAPIConfig
    {
        public static string BaseURL = "https://pro-api.coinmarketcap.com";
        public string API_KEY = "2f0da57a-006f-4912-9823-cf1a2b826296";
        public string LatestQoutesURL = $"{BaseURL}/v2/cryptocurrency/quotes/latest";
    }
}
