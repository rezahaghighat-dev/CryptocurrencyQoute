using App.Domain.Core.AppServices;
using App.Domain.Core.DTOs;
using App.Domain.Core.Services;
using Newtonsoft.Json.Linq;

namespace App.Domain.AppServices
{
    public class CurrencyInfoAppService : ICurrencyInfoAppService
    {
        private readonly ICurrencyInfoService _currencyInfoService;

        public CurrencyInfoAppService(ICurrencyInfoService currencyInfoService)
        {
            _currencyInfoService = currencyInfoService;
        }
        public async Task<ServiceResponse<string>> GetCurrencyPrice(string currency)
        {
            var serviceResponse = new ServiceResponse<string>();
            string result = $"{currency}/USD = {await _currencyInfoService.GetCurrencyPriceWithBaseUSD(currency)}\n{currency}/EUR = {await _currencyInfoService.GetCurrencyPriceWithBaseEUR(currency)}\n{currency}/BRL = {await _currencyInfoService.GetCurrencyPriceWithBaseBRL(currency)}\n{currency}/GBP = {await _currencyInfoService.GetCurrencyPriceWithBaseGBP(currency)}\n{currency}/AUD = {await _currencyInfoService.GetCurrencyPriceWithBaseAUD(currency)}";
            serviceResponse.Data = result;
            return serviceResponse;
            //return await _currencyInfoService.GetCurrencyPriceWithBaseAUD(currency);
        }
    }
}
