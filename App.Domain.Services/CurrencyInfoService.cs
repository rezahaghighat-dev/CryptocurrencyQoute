using App.Domain.Core.Data;
using App.Domain.Core.Services;
using Newtonsoft.Json.Linq;

namespace App.Domain.Services
{
    public class CurrencyInfoService : ICurrencyInfoService
    {
        private readonly ICurrencyInfoRepository _currencyInfoRepository;

        public CurrencyInfoService(ICurrencyInfoRepository currencyInfoRepository)
        {
            _currencyInfoRepository = currencyInfoRepository;
        }

        public async Task<string> GetCurrencyPriceWithBaseAUD(string currency)
        {
            var jsonResult = await _currencyInfoRepository.GetCurrencyPriceWithBaseAUD(currency);
            var json = JObject.Parse(jsonResult);
            var price = json["data"][currency][0]["quote"]["AUD"]["price"].Value<decimal>();
            return price.ToString();
        }

        public async Task<string> GetCurrencyPriceWithBaseBRL(string currency)
        {
            var jsonResult = await _currencyInfoRepository.GetCurrencyPriceWithBaseBRL(currency);
            var json = JObject.Parse(jsonResult);
            var price = json["data"][currency][0]["quote"]["BRL"]["price"].Value<decimal>();
            return price.ToString();
        }

        public async Task<string> GetCurrencyPriceWithBaseEUR(string currency)
        {
            var jsonResult = await _currencyInfoRepository.GetCurrencyPriceWithBaseEUR(currency);
            var json = JObject.Parse(jsonResult);
            var price = json["data"][currency][0]["quote"]["EUR"]["price"].Value<decimal>();
            return price.ToString();
        }

        public async Task<string> GetCurrencyPriceWithBaseGBP(string currency)
        {
            var jsonResult = await _currencyInfoRepository.GetCurrencyPriceWithBaseGBP(currency);
            var json = JObject.Parse(jsonResult);
            var price = json["data"][currency][0]["quote"]["GBP"]["price"].Value<decimal>();
            return price.ToString();
        }

        public async Task<string> GetCurrencyPriceWithBaseUSD(string currency)
        {
            var jsonResult = await _currencyInfoRepository.GetCurrencyPriceWithBaseUSD(currency);
            var json = JObject.Parse(jsonResult);
            var price = json["data"][currency][0]["quote"]["USD"]["price"].Value<decimal>();
            return price.ToString();
        }
    }
}
